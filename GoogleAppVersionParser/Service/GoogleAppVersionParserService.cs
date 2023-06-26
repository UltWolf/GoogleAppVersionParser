namespace GoogleAppVersionParser.Service
{
    public class GoogleAppVersionParserService
    {
        public async static Task<string> GetTextVersionAsync(string appURL)
        {


            var cookieContainer = new System.Net.CookieContainer();
            //cookieContainer.Add(new System.Net.Cookie("HSID", "AZ3f2YDQaDPcLaRpN") { Domain = "play.google.com" });
            //cookieContainer.Add(new System.Net.Cookie("SSID", "A7hUdCUGdsgWWiNji") { Domain = "play.google.com" });
            cookieContainer.Add(new System.Net.Cookie("NID", "511=T_2ZlahNo9o7mV8EaJFAkpVPLqMraWJOvl0U0wy_ZIcdK3B-Upy9Ndip4ovi3vlgTNSQZQtzvIxshkILu4_iF5atcvg_Top1tuSWXQioej4ipJg--OWpaO7t3EnWyh6BWqEF1rm-OZTQM-IJHKQe5eoxCpROc4VzMNtuv19J5NA") { Domain = "play.google.com" });

            var handler = new HttpClientHandler
            {
                CookieContainer = cookieContainer
            };

            using (var httpClient = new HttpClient(handler))
            {
                var requestUri = "https://play.google.com/_/PlayStoreUi/data/batchexecute?rpcids=CLXjtf%2CA6yuRe%2CcBDeQe%2CWs7gDc%2Cag2B9c%2Cc5NYSc%2CoCPfdb%2CMTfLfb&source-path=%2Fstore%2Fapps%2Fdetails&f.sid=-7903244907915476801&bl=boq_playuiserver_20230619.09_p0&hl=ru&authuser=0&soc-app=121&soc-platform=1&soc-device=4&_reqid=242024&rt=c";
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("authority", "play.google.com");
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept", "*/*");
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("cache-control", "no-cache");
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("accept-language", "en,en-US;q=0.9,ru-RU;q=0.8,ru;q=0.7");
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "text/plain; charset=utf-8");
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate, br");
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Connection", "keep-alive");
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "PostmanRuntime/7.32.3");

                var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);
                string requestBody = "f.req=%5B%5B%5B%22CLXjtf%22%2C%22%5B%5B%5C%22com.connectiontelecom.telvivaconnect%5C%22%2C7%5D%5D%22%2Cnull%2C%221%22%5D%2C%5B%22A6yuRe%22%2C%22%5B%5B%5C%22com.connectiontelecom.telvivaconnect%5C%22%2C7%5D%5D%22%2Cnull%2C%223%22%5D%2C%5B%22cBDeQe%22%2C%22%5Bnull%2C%5B%5C%22com.connectiontelecom.telvivaconnect%5C%22%2C7%5D%5D%22%2Cnull%2C%225%22%5D%2C%5B%22Ws7gDc%22%2C%22%5Bnull%2Cnull%2C%5B%5B1%2C9%2C10%2C11%2C13%2C14%2C19%2C20%2C38%2C43%2C47%2C49%2C52%2C58%2C59%2C63%2C69%2C70%2C73%2C74%2C75%2C78%2C79%2C80%2C91%2C92%2C95%2C96%2C97%2C100%2C101%2C103%2C106%2C112%2C119%2C129%2C137%2C139%2C141%2C145%2C146%2C151%5D%5D%2C%5B%5B%5B1%2Cnull%2C1%5D%2Cnull%2C%5B%5Bnull%2C%5B%5D%5D%5D%2Cnull%2Cnull%2Cnull%2Cnull%2C%5Bnull%2C2%5D%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2C%5B1%5D%5D%2C%5Bnull%2C%5B%5Bnull%2C%5B%5D%5D%5D%5D%2C%5Bnull%2C%5B%5Bnull%2C%5B%5D%5D%5D%2Cnull%2C%5B1%5D%5D%2C%5Bnull%2C%5B%5Bnull%2C%5B%5D%5D%5D%5D%2Cnull%2Cnull%2Cnull%2Cnull%2C%5B%5B%5Bnull%2C%5B%5D%5D%5D%5D%2C%5B%5B%5Bnull%2C%5B%5D%5D%5D%5D%5D%2Cnull%2C%5B%5B%5C%22com.connectiontelecom.telvivaconnect%5C%22%2C7%5D%5D%5D%22%2Cnull%2C%227%22%5D%2C%5B%22ag2B9c%22%2C%22%5B%5Bnull%2C%5B%5C%22com.connectiontelecom.telvivaconnect%5C%22%2C7%5D%2Cnull%2C%5B%5B3%2C%5B6%2Cnull%2C%5B%5D%5D%5D%2Cnull%2Cnull%2C%5B1%2C8%5D%5D%5D%2C%5B1%5D%5D%22%2Cnull%2C%229%22%5D%2C%5B%22c5NYSc%22%2C%22%5Bnull%2C%5B%5C%22com.connectiontelecom.telvivaconnect%5C%22%2C7%5D%5D%22%2Cnull%2C%2211%22%5D%2C%5B%22oCPfdb%22%2C%22%5Bnull%2C%5B1%2Cnull%2C%5B40%5D%2Cnull%2C%5Bnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2C2%5D%5D%2C%5B%5C%22com.connectiontelecom.telvivaconnect%5C%22%2C7%5D%5D%22%2Cnull%2C%2213%22%5D%2C%5B%22Ws7gDc%22%2C%22%5Bnull%2Cnull%2C%5B%5B52%5D%5D%2C%5B%5Bnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2C%5B2%5D%5D%5D%2Cnull%2C%5B%5B%5C%22com.connectiontelecom.telvivaconnect%5C%22%2C7%5D%5D%5D%22%2Cnull%2C%2215%22%5D%2C%5B%22oCPfdb%22%2C%22%5Bnull%2C%5B2%2Cnull%2C%5B40%5D%2Cnull%2C%5Bnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2C2%5D%5D%2C%5B%5C%22com.connectiontelecom.telvivaconnect%5C%22%2C7%5D%5D%22%2Cnull%2C%2217%22%5D%2C%5B%22MTfLfb%22%2C%22%5Bnull%2C%5B%5C%22com.connectiontelecom.telvivaconnect%5C%22%2C7%5D%5D%22%2Cnull%2C%2219%22%5D%5D%5D&at=ANHXBSuYBq0dhTcnY_gctD0-FSH3%3A1687768822772&";
                StringContent content = new StringContent(requestBody);
                HttpResponseMessage result = await httpClient.PostAsync(requestUri, content);
                if (result.IsSuccessStatusCode)
                {
                    return await result.Content.ReadAsStringAsync();
                }
                return "";

            }
        }
    }
}
