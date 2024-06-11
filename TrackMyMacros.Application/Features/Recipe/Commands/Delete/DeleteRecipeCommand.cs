namespace TrackMyMacros.Application.Features.Recipe.Commands.Delete
{
    public class DeleteRecipeCommand : RequestBase<Result>
    {
        public Guid Id { get; set; }
    }
}