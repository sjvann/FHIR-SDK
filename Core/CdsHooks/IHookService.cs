
using Core.CdsHooks.Cards;
using Core.CdsHooks.Request;

namespace Core.CdsHooks
{
    public interface IHookService
    {
        public IEnumerable<HookModel> GetHookList();
        public HookModel GetHook(string id);
        public IEnumerable<CardModel> GetResponseCards(string serviceId, RequestModel source);
    }
}