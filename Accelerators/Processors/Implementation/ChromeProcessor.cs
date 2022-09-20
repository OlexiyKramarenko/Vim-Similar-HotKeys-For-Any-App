using Accelerators.Handlers;
using Accelerators.Handlers.Chrome.Modes.Normal;
using Accelerators.Modes.Implementation;
using System;
using System.Collections.Generic;

namespace Accelerators.Processors.Implementation
{
    public class ChromeProcessor : ProcessorBase
    {
        protected override Dictionary<Type, HandlerBase> StateHandlerDictionary { get; }

        public ChromeProcessor()
        {
            StateHandlerDictionary = new Dictionary<Type, HandlerBase>
            {
                {
                   typeof(NormalState),
                                   new Bookmark(
                                    new BookmarksList(
                                     new CloseAllDocuments(
                                      new CloseProgram(
                                       new CloseTab(
                                        new ConsoleTab(
                                         new CreateTab(
                                          new Elements(
                                           new Extensions(
                                            new History(
                                             new NextTab(
                                              new Minimize(
                                               new Maximize(
                                                 new PinTab(
                                                  new PrevTab(
                                                   new ReopenClosedTab())))))))))))))))
                }
            };
        }
    }
}
