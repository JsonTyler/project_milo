namespace project_milo.Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddParticles(this IServiceCollection services)
       => services.AddScoped<ParticlesService>();
    }
}
