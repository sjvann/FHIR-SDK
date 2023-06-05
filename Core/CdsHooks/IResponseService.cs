

using Core.CdsHooks.Cards;
using Core.CdsHooks.Request;

namespace Core.CdsHooks
{
    public interface IResponseService
    {
        void Setup(HookServiceModel hook, RequestModel source);
        List<CardModel>? GetResponseContent();
    }
}
