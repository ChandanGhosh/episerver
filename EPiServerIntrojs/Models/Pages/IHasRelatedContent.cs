using EPiServer.Core;

namespace EPiServerIntrojs.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
