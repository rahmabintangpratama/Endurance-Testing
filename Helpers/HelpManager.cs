using System.Text;

namespace Endurance_Testing.Helpers
{
    public static class HelpManager
    {
        public static string GenerateHelpMessage()
        {
            StringBuilder helpMessage = new StringBuilder();

            helpMessage.AppendLine("User Guide for Endurance Testing:");
            helpMessage.AppendLine();
            helpMessage.AppendLine("1. Enter the target URL in the URL column.");
            helpMessage.AppendLine("2. Enter the number of requests in the Requests column (maximum 8 digits).");
            helpMessage.AppendLine("3. Enter the duration for the endurance test in the Time column (in seconds, minutes, or hours).");
            helpMessage.AppendLine("4. Select the time period (seconds, minutes, or hours) using the radio buttons.");
            helpMessage.AppendLine("5. Enter the timeout per round in the Timeout column (in seconds).");
            helpMessage.AppendLine("6. Click the 'Start' button to begin the endurance testing.");
            helpMessage.AppendLine("7. Monitor the results in the output area and time left in real-time.");
            helpMessage.AppendLine("8. After the test, the output will display:");
            helpMessage.AppendLine("    - Total Requests: The total number of requests sent during the test.");
            helpMessage.AppendLine("    - Successful Requests: The number of requests that received a successful HTTP 200 (OK) response.");
            helpMessage.AppendLine("    - Failed Requests: The number of requests that did not receive an HTTP 200 (OK) response or timed out.");
            helpMessage.AppendLine("    - Average Computer's CPU Usage: The average percentage of computer's CPU utilization during the test.");
            helpMessage.AppendLine("    - Average Computer's RAM Usage: The average computer's RAM utilization in megabytes during the test.");
            helpMessage.AppendLine("    - Average Load Time: The average amount of time taken to fully receive each request, reflecting the quality and responsiveness from the user's perspective.");
            helpMessage.AppendLine("    - Average Wait Time: The average time taken until receiving the first byte after sending a request.");
            helpMessage.AppendLine("    - Average Response Time: The average response time for all requests (including successful and failed).");
            helpMessage.AppendLine("    - Average Throughput: The average number of requests processed per second.");
            helpMessage.AppendLine("    - Average Error Rate: The percentage of requests that failed or timed out.");
            helpMessage.AppendLine("    - Average Round Duration: The average time in seconds it takes to complete one round of requests.");
            helpMessage.AppendLine("9.Click the 'Clear' button to reset the input fields and output area.");
            helpMessage.AppendLine("10. Click the 'Export' button to save test results in various formats:");
            helpMessage.AppendLine("    - Excel (.xlsx)");
            helpMessage.AppendLine("    - CSV (.csv)");
            helpMessage.AppendLine("    - JSON (.json)");
            helpMessage.AppendLine("    - HTML (.html)");
            helpMessage.AppendLine();
            helpMessage.AppendLine("Note:");
            helpMessage.AppendLine("1. Ensure that your internet connection is stable and reliable for conducting this test.");
            helpMessage.AppendLine("2. Be aware that the device may become slower during the testing process, so ensure that your device specifications are adequate.");
            helpMessage.AppendLine("3. Additionally, the total duration of the test may not match the input time in the Time column due to processing time required for handling requests and responses.");

            return helpMessage.ToString();
        }
    }
}