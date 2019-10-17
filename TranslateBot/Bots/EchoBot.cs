// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
//
// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.5.0

using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using TranslateBot.Data;
using TranslateBot.Models;
using TranslateBot.Modules;
using TranslateBot.Repositories;

namespace TranslateBot.Bots
{
    public class EchoBot : ActivityHandler
    {

        private IRepository repository;


        public EchoBot(IRepository repository)
        {
            this.repository = repository;

        }

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            await turnContext.SendActivityAsync(MessageFactory.Text(await TranslateText(turnContext.Activity.Text)), cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text($"Hello and welcome!"), cancellationToken);
                }
            }
        }

        protected async Task<string> TranslateText(string text)
        {


            var splitStr = Regex.Split(text, @"(?<=[\.!\?;])\s+");
            for (int i = 0; i < splitStr.Length; i++)
            {
                if (repository.Exists(splitStr[i]))
                    splitStr[i] = repository.Get(splitStr[i]).dst;
                else
                {
                    string tmp = await TranslateService.Translator.translate(splitStr[i]);
                    repository.Add(new Phrase { src = splitStr[i], dst = tmp });
                    splitStr[i] = tmp;
                }
            }

            string res = splitStr.Aggregate(((prev, current) => (prev + " " + current)));
            return res;
        }
    }
}
