using Microsoft.JSInterop;

namespace project_milo.Services
{
    public class ParticlesService
    {
        private IJSRuntime _jsRuntime;
        public ParticlesService(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
        }
        public async Task Particles()
        {
            await _jsRuntime.InvokeVoidAsync("myParticles.showParticles");
        }
    }
}
