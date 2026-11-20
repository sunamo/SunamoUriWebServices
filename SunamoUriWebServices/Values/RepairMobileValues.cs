namespace SunamoUriWebServices.Values;

/// <summary>
/// Represents the repair mobile values type.
/// </summary>
public class RepairMobileValues
{
    /// <summary>
    /// Gets or sets the all repair services ova.
    /// </summary>
    public static List<string>? AllRepairServicesOva { get; set; }

    /// <summary>
    /// Gets or sets the all repair kit shops.
    /// </summary>
    public static List<string>? AllRepairKitShops { get; set; }

    /// <summary>
    /// Gets or sets the repair kit shops free pickup ostrava.
    /// </summary>
    public static List<string>? RepairKitShopsFreePickupOstrava { get; set; }

    static RepairMobileValues()
    {
        AllRepairServicesOva = new List<string>(["levnejmobil.cz", "bettacomp.cz", "tadyspravismobil.cz", "atcmobile.cz", "iphoneostrava.cz", "mobilcity.cz", "iloveservis.cz", "prontmobil.cz", "mujmobilnitelefon.cz"]);
        AllRepairKitShops = new List<string>(["mobil-obaly.cz", "deltamobile.cz", "e-shop.vmcomp.cz", "gc-baterie.cz", "dianashop.cz", "neven.cz", "multo.cz", "jenifer.cz", "naradi-pajky.cz", "servatech.cz", "dilyamobily.cz", "f-mobil.cz", "mobilmax.cz", "mobilprovas.cz", "servisnidily.cz", "matrixmobil.cz", "lcdpartner.com", "stmobil.cz", "ptmobil.cz", "pajtech.cz"]);
        RepairKitShopsFreePickupOstrava = new List<string>(["levnejmobil.cz", "hotair.cz", "vsekmobilu.cz"]);
    }
}
