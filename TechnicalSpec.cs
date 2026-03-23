public class TechnicalSpec
{
    public string ProductDimensions { get; set; } = string.Empty; // Dimensões do produto (LxPxH em mm)
    public string HobDimensions { get; set; } = string.Empty;     // Dimensões da placa (mm)
    public string Voltage { get; set; } = string.Empty;           // Voltagem
    public string ElectricPower { get; set; } = string.Empty;     // Potência elétrica (kW)
    public string GasPower { get; set; } = string.Empty;          // Potência a gás (kW)
    public string GasConsumption { get; set; } = string.Empty;    // Consumo (mc/h - LPG kh/h)
    public string GrossWeight { get; set; } = string.Empty;       // Peso bruto (kg)
    public string PackagingVolume { get; set; } = string.Empty;   // Volume da embalagem (m³)
    public string Construction { get; set; } = string.Empty;      // Construção / Material (ex: Stainless steel)
    public string WaterConnection { get; set; } = string.Empty;   // Conexão de água
    public string LoadingWater { get; set; } = string.Empty;      // Carregamento de água
    public string HeartProbe { get; set; } = string.Empty;        // Sonda de coração (ex: Optional)
}

