using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace AssetTrackingSystem
{
    public static class NvdApiClient
    {
        private static readonly HttpClient http = new HttpClient();

        public static async Task<List<VulnerabilityResult>>
            SearchVulnerabilities(string osName, string osVersion)
        {
            var list = new List<VulnerabilityResult>();

            string keyword = $"{osName} {osVersion}".Replace(" ", "%20");

            string url =
                $"https://services.nvd.nist.gov/rest/json/cves/2.0?keywordSearch={keyword}";

            var json = await http.GetStringAsync(url);
            var root = JObject.Parse(json);

            var vulns = root["vulnerabilities"];

            if (vulns == null)
                return list;

            foreach (var item in vulns)
            {
                var cve = item["cve"];

                string id = cve["id"]?.ToString();

                string description =
                    cve["descriptions"]?[0]?["value"]?.ToString() ?? "N/A";

                var metrics =
                    cve["metrics"]?["cvssMetricV31"]?[0];

                if (metrics == null)
                    continue;

                string severity =
                    metrics["cvssData"]?["baseSeverity"]?.ToString() ?? "";

                double score =
                    metrics["cvssData"]?["baseScore"]?.ToObject<double>() ?? 0;

                if (severity != "HIGH" && severity != "CRITICAL")
                    continue;

                list.Add(new VulnerabilityResult
                {
                    CveId = id,
                    Severity = severity,
                    Score = score,
                    Description = description
                });
            }

            return list;
        }
    }
}
