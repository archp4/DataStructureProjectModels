namespace DataStructureProjectModels.Models
{
    public class Site
    {
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public bool IsAvailable { get; set; }

        public int slotAvaible { get; set; }

        public Site(int siteId, string siteName, string siteDescription, bool isAvailable, int slotAvaible)
        {
            SiteId = siteId;
            SiteName = siteName;
            SiteDescription = siteDescription;
            IsAvailable = isAvailable;
            this.slotAvaible = slotAvaible;
        }
        public Site() { }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
