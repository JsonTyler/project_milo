window.myParticles = {
    showParticles: function () {
            particlesJS.load('particles-js', '../particles.json', function () {
                console.log('callback - particles.js config loaded');
                let el = document.querySelector(".particles-js-canvas-el");
        });
    }
}
