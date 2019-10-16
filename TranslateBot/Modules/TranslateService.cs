using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TranslateBot.Modules
{
    public class TranslateService
    {
        public class TranslationResult
        {
            public DetectedLanguage DetectedLanguage { get; set; }
            public TextResult SourceText { get; set; }
            public Translation[] Translations { get; set; }
        }

        public class DetectedLanguage
        {
            public string Language { get; set; }
            public float Score { get; set; }
        }

        public class TextResult
        {
            public string Text { get; set; }
            public string Script { get; set; }
        }

        public class Translation
        {
            public string Text { get; set; }
            public TextResult Transliteration { get; set; }
            public string To { get; set; }
            public Alignment Alignment { get; set; }
            public SentenceLength SentLen { get; set; }
        }

        public class Alignment
        {
            public string Proj { get; set; }
        }

        public class SentenceLength
        {
            public int[] SrcSentLen { get; set; }
            public int[] TransSentLen { get; set; }
        }

        public class Translator
        {
           

            private const string key_var = "ee67d621bd704e188f77a1f40bc37524";
            private static readonly string subscriptionKey = key_var;

            private const string endpoint_var = "https://api.cognitive.microsofttranslator.com/";
            private static readonly string endpoint = endpoint_var;


            static public async Task<string> TranslateTextRequest(string subscriptionKey, string endpoint, string route, string inputText)
            {

                object[] body = new object[] { new { Text = inputText } };
                var requestBody = JsonConvert.SerializeObject(body);

                using (var client = new HttpClient())
                using (var request = new HttpRequestMessage())
                {
                    request.Method = HttpMethod.Post;
                    request.RequestUri = new Uri(endpoint + route);
                    request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                    request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                    request.Headers.Add("X-ClientTraceId", Guid.NewGuid().ToString());

                    HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);

                    string result = await response.Content.ReadAsStringAsync();

                    TranslationResult[] deserializedOutput = JsonConvert.DeserializeObject<TranslationResult[]>(result);
                    return deserializedOutput[0].Translations[0].Text;
                }
            }

            public static async Task<string> translate(string text)
            {
                string route = "/translate?api-version=3.0&to=en";
                return await TranslateTextRequest(subscriptionKey, endpoint, route, text);


            }
        }
    }
}
