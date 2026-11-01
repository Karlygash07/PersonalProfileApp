// Мазмұн JavaScript болмаса да көрінеді. Анимациялар тек қосымша әсер береді.
(() => {
    const motionPreference = window.matchMedia("(prefers-reduced-motion: reduce)");
    if (motionPreference.matches || !("IntersectionObserver" in window) ||
        !("animate" in Element.prototype)) {
        return;
    }

    const elements = document.querySelectorAll("[data-reveal]");
    const runningAnimations = new Set();
    const observer = new IntersectionObserver((entries) => {
        let order = 0;
        for (const entry of entries) {
            if (!entry.isIntersecting) continue;
            observer.unobserve(entry.target);
            if (motionPreference.matches) continue;

            const animation = entry.target.animate(
                [
                    { opacity: 0, translate: "0 16px" },
                    { opacity: 1, translate: "0 0" }
                ],
                {
                    duration: 420,
                    delay: Math.min(order++, 3) * 60,
                    easing: "cubic-bezier(0.2, 0, 0, 1)",
                    fill: "backwards"
                }
            );
            runningAnimations.add(animation);
            animation.finished.then(
                () => runningAnimations.delete(animation),
                () => runningAnimations.delete(animation)
            );
        }
    }, { threshold: 0, rootMargin: "0px 0px -24px 0px" });

    elements.forEach(element => observer.observe(element));

    // Пайдаланушы ОС баптауын өзгерткенде қозғалысты бірден тоқтатамыз.
    motionPreference.addEventListener("change", (event) => {
        if (!event.matches) return;
        observer.disconnect();
        runningAnimations.forEach(animation => animation.cancel());
        runningAnimations.clear();
    });
})();
