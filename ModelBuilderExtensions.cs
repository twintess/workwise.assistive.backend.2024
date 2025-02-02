using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace workwise.assistive.backend
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder builder)
        {
            var roles = new List<IdentityRole>()
            {
                new() { Name = "new-account-request-reader", NormalizedName = "NEW-ACCOUNT-REQUEST-READER" },
                new() { Name = "new-account-request-contributor", NormalizedName = "NEW-ACCOUNT-REQUEST-CONTRIBUTOR" },
                new() { Name = "user-password-reset-operator", NormalizedName = "USER-PASSWORD-RESET-OPERATOR" },
                new() { Name = "user-mfa-details-reader", NormalizedName = "USER-MFA-DETAILS-READER" },
                new() { Name = "domain-reader", NormalizedName = "DOMAIN-READER" },
                new() { Name = "disk-request-contributor", NormalizedName = "DISK-REQUEST-CONTRIBUTOR" },
                new() { Name = "disk-request-reader", NormalizedName = "DISK-REQUEST-READER" },
                new() { Name = "audit-reader", NormalizedName = "AUDIT-READER" },
                new() { Name = "audit-settings-reader", NormalizedName = "AUDIT-SETTINGS-READER" },
                new() { Name = "zabbix-servers-report-reader", NormalizedName = "ZABBIX-SERVERS-REPORT-READER" },
                new() { Name = "zabbix-incidents-reader", NormalizedName = "ZABBIX-INCIDENTS-READER" },
                new() { Name = "zabbix-statistics-reader", NormalizedName = "ZABBIX-STATISTICS-READER" },
                new() { Name = "survey-report-reader", NormalizedName = "SURVEY-REPORT-READER" },
                new() { Name = "surver-interaction-reader", NormalizedName = "SURVER-INTERACTION-READER" },
                new() { Name = "personalization-lockscreen-reader", NormalizedName = "PERSONALIZATION-LOCKSCREEN-READER" },
                new() { Name = "personalization-schedule-reader", NormalizedName = "PERSONALIZATION-SCHEDULE-READER" },
                new() { Name = "popup-window-contributor", NormalizedName = "POPUP-WINDOW-CONTRIBUTOR" },
                new() { Name = "popup-distribution-contributor", NormalizedName = "POPUP-DISTRIBUTION-CONTRIBUTOR" },
                new() { Name = "popup-window-reader", NormalizedName = "POPUP-WINDOW-READER" },
                new() { Name = "popup-distribution-reader", NormalizedName = "POPUP-DISTRIBUTION-READER" },
                new() { Name = "popup-schedule-reader", NormalizedName = "POPUP-SCHEDULE-READER" },
                new() { Name = "portal-admin", NormalizedName = "PORTAL-ADMIN" },
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
