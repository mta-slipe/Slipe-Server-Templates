using SlipeServer.Server.ServerBuilders;

namespace AdditionalResourceProjectTemplate;

public static class ServerBuilderExtensions
{
    public static void AddAdditionalResourceProjectTemplate(this ServerBuilder builder)
    {
        builder.AddBuildStep(server =>
        {
            var resource = new AdditionalResourceProjectTemplateResource(server);
            server.AddAdditionalResource(resource, resource.AdditionalFiles);
        });
        builder.AddLogic<AdditionalResourceProjectTemplateResourceLogic>();
    }
}
