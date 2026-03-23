using KitchenEquip.Models;

namespace KitchenEquip.Services
{
    /// <summary>
    /// Implementação mock para desenvolvimento.
    /// Substituir por serviço com EF Core / repositório real em produção.
    /// </summary>
    public class MockProductService : IProductService
    {
        private readonly List<Product> _products = new()
        {
           new Product
            {
                Id = 1,
                Name = "GE 509 EL AUTOMATIC",
                ShortDescription = "Grelhador clamshell elétrico de piso (freestanding) com tecnologia Grillvapor e abertura automática.",
                FullDescription = "O Overgrill é um sistema avançado que combina a tecnologia patenteada Grillvapor com duas grelhas elétricas em formato clamshell. A versão GE 509 EL AUTOMATIC opera de forma autônoma: o operador seleciona o programa, fecha a grelha e o sistema inicia o cozimento, abrindo automaticamente ao finalizar. O Sistema Integrado de Aquecimento (IHE) distribui o calor uniformemente, ideal para alimentos congelados ou espessos (até 50 mm). A umidificação do Grillvapor acelera a cocção, reduz a perda de peso em 20% e preserva as cores naturais do alimento.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GE-509-EL-A.jpg",
                Category = "Overgrill",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "500, 900, 900",
                    HobDimensions = "380x530",
                    Voltage = "400V 3N - 11,6 50/60 Hz / 230V 3 - 20,10 - 50/60 Hz",
                    ElectricPower = "8",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "116",
                    PackagingVolume = "0.76",
                    Construction = "Aço Inox AISI 304 Scotch Brite",
                    WaterConnection = "-",
                    LoadingWater = "Manual",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 2,
                Name = "GE 509 EL AUTOMATIC TOP",
                ShortDescription = "Grelhador clamshell elétrico de bancada (countertop) com tecnologia Grillvapor e abertura automática.",
                FullDescription = "O Overgrill é um sistema avançado que combina a tecnologia patenteada Grillvapor com duas grelhas elétricas em formato clamshell. A versão de bancada GE 509 EL AUTOMATIC TOP opera de forma autônoma: o operador seleciona o programa, fecha a grelha e o sistema inicia o cozimento, abrindo automaticamente ao finalizar. O Sistema Integrado de Aquecimento (IHE) distribui o calor uniformemente, adaptando-se a alimentos de até 50 mm de espessura. A umidificação do Grillvapor acelera a cocção e reduz a perda de peso (shrinkage) em até 20%.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GE-509-EL-A-TOP.jpg",
                Category = "Overgrill",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "500, 900, 900",
                    HobDimensions = "380x530",
                    Voltage = "400V 3N - 11,6 50/60 Hz / 230V 3 - 20,10 - 50/60 Hz",
                    ElectricPower = "8",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "104",
                    PackagingVolume = "0.46",
                    Construction = "Aço Inox AISI 304 Scotch Brite",
                    WaterConnection = "-",
                    LoadingWater = "Manual",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 3,
                Name = "GE 509 EL TOP",
                ShortDescription = "Grelhador clamshell elétrico de bancada (countertop) com tecnologia patenteada Grillvapor.",
                FullDescription = "O GE 509 EL TOP faz parte da linha Overgrill, projetado para oferecer resultados perfeitos de grelhado independentemente do operador. Este equipamento de bancada combina a tecnologia Grillvapor com o fechamento clamshell. Uma vez finalizado o programa memorizado, o equipamento sinaliza para abertura manual. Graças ao Sistema IHE, o calor é excepcionalmente bem distribuído, lidando facilmente com produtos congelados. A umidificação acelera a cocção e reduz o ressecamento da carne.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GE-509-EL-TOP.jpg",
                Category = "Overgrill",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "500, 900, 900",
                    HobDimensions = "380x530",
                    Voltage = "400V 3N - 11,6 50/60 Hz / 230V 3 - 20,10 - 50/60 Hz",
                    ElectricPower = "8",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "96",
                    PackagingVolume = "0.46",
                    Construction = "Aço Inox AISI 304 Scotch Brite",
                    WaterConnection = "-",
                    LoadingWater = "Manual",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 4,
                Name = "GE 509 EL",
                ShortDescription = "Grelhador clamshell elétrico de piso (freestanding) com tecnologia patenteada Grillvapor.",
                FullDescription = "O GE 509 EL é um sistema freestanding da linha Overgrill, desenhado para padronizar a qualidade do grelhado na cozinha profissional. Combina tecnologia Grillvapor e fechamento clamshell para grelhar ambos os lados simultaneamente. O operador é sinalizado para a abertura manual ao término do ciclo. O Sistema IHE garante distribuição de calor perfeita até para produtos congelados de até 50 mm. A tecnologia de vapor reduz a perda de peso dos alimentos em 20%, garantindo suculência.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GE-509-EL.jpg",
                Category = "Overgrill",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "500, 900, 900",
                    HobDimensions = "380x530",
                    Voltage = "400V 3N - 11,6 50/60 Hz / 230V 3 - 20,10 - 50/60 Hz",
                    ElectricPower = "8",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "111",
                    PackagingVolume = "0.76",
                    Construction = "Aço Inox AISI 304 Scotch Brite",
                    WaterConnection = "-",
                    LoadingWater = "Manual",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 5,
                Name = "GE 519 EL TOP",
                ShortDescription = "Grelhador clamshell elétrico de bancada (countertop) com tecnologia Grillvapor e abastecimento automático de água.",
                FullDescription = "O GE 519 EL TOP eleva a praticidade na cozinha profissional. Este modelo de bancada da linha Overgrill traz o grande diferencial do abastecimento automático de água (Water Connection), otimizando o tempo do operador no uso contínuo da tecnologia Grillvapor. O sistema clamshell patenteado permite cocção simultânea em ambos os lados, enquanto o calor radiante umidificado sela rapidamente a carne, preservando até 20% mais do peso e dos sucos naturais do alimento em comparação às grelhas tradicionais.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GE-519-EL-TOP.jpg",
                Category = "Overgrill",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "500, 900, 900",
                    HobDimensions = "380x530",
                    Voltage = "400V 3N - 11,6 50/60 Hz / 230V 3 - 20,10 - 50/60 Hz",
                    ElectricPower = "8",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "96",
                    PackagingVolume = "0.46",
                    Construction = "Aço Inox AISI 304 Scotch Brite",
                    WaterConnection = "Sim",
                    LoadingWater = "Automático",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 6,
                Name = "GE 519 EL AUTOMATIC TOP",
                ShortDescription = "Grelhador clamshell elétrico de bancada com abastecimento automático de água e abertura automática.",
                FullDescription = "O auge da automação em grelhadores de bancada. O GE 519 EL AUTOMATIC TOP combina a dupla cocção do sistema clamshell com três grandes facilitadores: programas de cozimento memorizáveis, abertura automática ao fim do ciclo e conexão direta à rede de água para abastecimento automático do sistema Grillvapor. O Sistema Integrado de Aquecimento (IHE) lida sem dificuldades com alimentos congelados de até 50 mm de espessura, garantindo padronização absoluta no preparo.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GE-519-EL-A-TOP.jpg",
                Category = "Overgrill",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "500, 900, 900",
                    HobDimensions = "380x530",
                    Voltage = "400V 3N - 11,6 - 50/60 Hz / 230V 3 - 20,10 - 50/60 Hz",
                    ElectricPower = "8",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "104",
                    PackagingVolume = "0.46",
                    Construction = "Aço Inox AISI 304 Scotch Brite",
                    WaterConnection = "Sim",
                    LoadingWater = "Automático",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 7,
                Name = "GE 519 EL AUTOMATIC",
                ShortDescription = "Grelhador clamshell elétrico de piso (freestanding) com automação total de abertura e água.",
                FullDescription = "Produtividade e padronização em formato de piso (freestanding). O GE 519 EL AUTOMATIC assume o controle da grelha por você: basta selecionar o programa e fechar a tampa. O equipamento cozinha ambos os lados simultaneamente com a umidade da tecnologia Grillvapor e abre sozinho ao terminar. A conexão direta de água elimina a necessidade de reabastecimento manual. Um equipamento robusto, essencial para operações de alto volume que exigem resultados perfeitos sem depender da experiência do operador.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GE-519-EL-A.jpg",
                Category = "Overgrill",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "500, 900, 900",
                    HobDimensions = "380x530",
                    Voltage = "400V 3N - 11,6 50/60 Hz / 230V 3 - 20,10 - 50/60 Hz",
                    ElectricPower = "8",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "116",
                    PackagingVolume = "0.76",
                    Construction = "Aço Inox AISI 304 Scotch Brite",
                    WaterConnection = "Sim",
                    LoadingWater = "Automático",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 8,
                Name = "GE 519 EL",
                ShortDescription = "Grelhador clamshell elétrico de piso (freestanding) com tecnologia Grillvapor e abastecimento automático de água.",
                FullDescription = "O GE 519 EL é a solução de piso (freestanding) ideal para quem busca a qualidade de cocção do sistema clamshell e Grillvapor, com a conveniência do abastecimento automático de água via conexão direta à rede. O operador é notificado ao fim do ciclo para abertura manual. Como em toda a linha Overgrill, o calor excepcional aliado ao vapor evita o ressecamento, preservando a textura, cor e o rendimento (redução de 20% na perda de peso) de carnes e hambúrgueres.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GE-519-EL.jpg",
                Category = "Overgrill",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "500, 900, 900",
                    HobDimensions = "380x530",
                    Voltage = "400V 3N - 11,6 50/60 Hz / 230V 3 - 20,10 - 50/60 Hz",
                    ElectricPower = "8",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "111",
                    PackagingVolume = "0.76",
                    Construction = "Aço Inox AISI 304 Scotch Brite",
                    WaterConnection = "Sim",
                    LoadingWater = "Automático",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 10,
                Name = "FT 1207 EL",
                ShortDescription = "Grelhador elétrico digital de piso (freestanding) - 3 zonas de cocção - Trifásico.",
                FullDescription = "Grelhador elétrico digital de piso (120x70 cm) focado em alta eficiência. Sua construção especial e tecnologia avançada garantem uma enorme economia de energia, mesmo operando em temperaturas extremas de até 300°C. O FT 1207 EL é o modelo de alta capacidade da linha Fry Top Green Energy, um equipamento projetado para pagar o próprio investimento em curto prazo através da drástica redução no consumo elétrico da sua operação.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/09/FT_1207_EL_monoblocco-2048x1606.jpg",
                Category = "Frytop Green Energy",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "1195, 700, 900",
                    HobDimensions = "1115x510",
                    Voltage = "380 - 415 V 3N - 50/60 Hz / 220 - 240V 3 - 50/60Hz",
                    ElectricPower = "8.4",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "220",
                    PackagingVolume = "0.9",
                    Construction = "Aço Inox",
                    WaterConnection = "-",
                    LoadingWater = "-",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 11,
                Name = "FT 1207 EL TOP",
                ShortDescription = "Grelhador elétrico digital de bancada (countertop) - 3 zonas de cocção - Trifásico.",
                FullDescription = "Versão de bancada do grelhador de 120x70 cm. Equipado com 3 zonas de cocção independentes, permite preparar diferentes tipos de alimentos simultaneamente em temperaturas distintas. Atinge rapidamente os 300°C com consumo energético reduzido. O FT 1207 EL TOP faz parte da inovadora linha Fry Top Green Energy, unindo alta produtividade em espaço reduzido e retorno rápido do investimento via economia de energia.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/FT_1207_EL_top-2048x1424.jpg",
                Category = "Frytop Green Energy",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "1195, 700, 400",
                    HobDimensions = "1115x510",
                    Voltage = "380 - 415 V 3N - 50/60 Hz / 220 - 240V 3 - 50/60Hz",
                    ElectricPower = "8.4",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "200",
                    PackagingVolume = "0.69",
                    Construction = "Aço Inox",
                    WaterConnection = "-",
                    LoadingWater = "-",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 12,
                Name = "FT 407 EL",
                ShortDescription = "Grelhador elétrico digital de piso (freestanding) - 1 zona de cocção - Trifásico.",
                FullDescription = "Grelhador elétrico digital compacto de piso (40x70 cm), ideal para operações que precisam de alta performance em espaços limitados. Alcança 300°C rapidamente mantendo um consumo mínimo de energia elétrica. O FT 407 EL compõe a linha Fry Top Green Energy, destacando-se pela tecnologia termal inteligente que garante a recuperação do investimento pelo baixo custo operacional.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/FT_407_EL_monoblocco-scaled.jpg",
                Category = "Frytop Green Energy",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "420, 700, 900",
                    HobDimensions = "340x510",
                    Voltage = "380 - 415 V 3N - 50/60 Hz / 220 - 240V 3 - 50/60Hz",
                    ElectricPower = "2.8",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "60",
                    PackagingVolume = "0.35",
                    Construction = "Aço Inox",
                    WaterConnection = "-",
                    LoadingWater = "-",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 13,
                Name = "FT 407 EL TOP",
                ShortDescription = "Grelhador elétrico digital de bancada (countertop) - 1 zona de cocção - Trifásico.",
                FullDescription = "Modelo de bancada compacto (40x70 cm) focado em eficiência e espaço. Desenvolvido para atingir altas temperaturas (300°C) com retenção de calor excepcional, minimizando o acionamento das resistências elétricas. O FT 407 EL TOP é a escolha ideal para cozinhas de apoio ou finalização, trazendo a tecnologia de economia da linha Fry Top Green Energy para qualquer bancada de trabalho.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/Frytop_407-Top.jpg",
                Category = "Frytop Green Energy",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "420, 700, 400",
                    HobDimensions = "340x510",
                    Voltage = "380 - 415 V 3N - 50/60 Hz / 220 - 240V 3 - 50/60Hz",
                    ElectricPower = "2.8",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "50",
                    PackagingVolume = "0.26",
                    Construction = "Aço Inox",
                    WaterConnection = "-",
                    LoadingWater = "-",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 14,
                Name = "FT 407 EL/M",
                ShortDescription = "Grelhador elétrico digital de piso (freestanding) - 1 zona de cocção - Monofásico.",
                FullDescription = "Versão Monofásica do grelhador de piso de 40x70 cm, perfeito para estabelecimentos que não possuem rede elétrica trifásica, mas exigem um equipamento profissional de alta performance. O FT 407 EL/M mantém toda a tecnologia da linha Fry Top Green Energy: atinge 300°C com baixo consumo, oferecendo um excelente custo-benefício e rápido retorno do investimento.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/09/FT_407_EL_monoblocco-M-scaled.jpg",
                Category = "Frytop Green Energy",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "420, 700, 900",
                    HobDimensions = "340x510",
                    Voltage = "380 - 415 V 3N - 50/60 Hz / 220 - 240V 3 - 50/60Hz / 220 - 240V - 50/60Hz",
                    ElectricPower = "2.8",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "60",
                    PackagingVolume = "0.35",
                    Construction = "Aço Inox",
                    WaterConnection = "-",
                    LoadingWater = "-",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 15,
                Name = "FT 407 EL/M TOP",
                ShortDescription = "Grelhador elétrico digital de bancada (countertop) - 1 zona de cocção - Monofásico.",
                FullDescription = "Modelo de bancada compacto (40x70 cm) com conexão elétrica Monofásica. Ideal para cafés, pequenos bistrôs ou food trucks que necessitam da potência de um grelhador profissional italiano (chegando a 300°C) sem adaptar a rede elétrica local. O FT 407 EL/M TOP traz a renomada eficiência energética da linha Green Energy para o seu balcão.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/Frytop_407-Top-M.jpg",
                Category = "Frytop Green Energy",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "420, 700, 400",
                    HobDimensions = "340x510",
                    Voltage = "380 - 415 V 3N - 50/60 Hz / 220 - 240V 3 - 50/60Hz / 220 - 240V - 50/60Hz",
                    ElectricPower = "2.8",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "50",
                    PackagingVolume = "0.26",
                    Construction = "Aço Inox",
                    WaterConnection = "-",
                    LoadingWater = "-",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 16,
                Name = "FT 409 EL",
                ShortDescription = "Grelhador elétrico digital de piso (freestanding) - 1 zona de cocção - Profundidade 90cm.",
                FullDescription = "Com 90 cm de profundidade, este grelhador de piso amplia significativamente a área útil de cocção mantendo a largura compacta de 40 cm. O FT 409 EL entrega o máximo em aproveitamento de espaço em linhas de cocção pesadas. Parte da linha Fry Top Green Energy, utiliza inércia térmica superior para manter 300°C constantes com drástica redução na conta de luz.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/FT_409_EL_monoblocco-scaled.jpg",
                Category = "Frytop Green Energy",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "420, 900, 900",
                    HobDimensions = "340x710",
                    Voltage = "380 - 415 V 3N - 50/60 Hz / 220 - 240V 3 - 50/60Hz",
                    ElectricPower = "4.2",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "80",
                    PackagingVolume = "0.44",
                    Construction = "Aço Inox",
                    WaterConnection = "-",
                    LoadingWater = "-",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 17,
                Name = "FT 409 EL TOP",
                ShortDescription = "Grelhador elétrico digital de bancada (countertop) - 1 zona de cocção - Profundidade 90cm.",
                FullDescription = "Modelo de bancada de alta profundidade (40x90 cm). O FT 409 EL TOP oferece uma chapa de 340x710 mm, garantindo alta produtividade contínua em formato countertop. A tecnologia Green Energy embarcada assegura que, mesmo operando em carga máxima a 300°C, a resistência seja ativada apenas quando estritamente necessário, pagando o próprio equipamento através da economia.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/Frytop_409-Top.jpg",
                Category = "Frytop Green Energy",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "420, 900, 400",
                    HobDimensions = "340x710",
                    Voltage = "380 - 415 V 3N - 50/60 Hz / 220 - 240V 3 - 50/60Hz",
                    ElectricPower = "4.2",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "70",
                    PackagingVolume = "0.33",
                    Construction = "Aço Inox",
                    WaterConnection = "-",
                    LoadingWater = "-",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 18,
                Name = "FT 807 EL",
                ShortDescription = "Grelhador elétrico digital de piso (freestanding) - 2 zonas de cocção - Trifásico.",
                FullDescription = "O equilíbrio perfeito para médias e grandes operações. Com 80x70 cm e duas zonas térmicas independentes, o FT 807 EL permite selar carnes de um lado e grelhar vegetais do outro com total precisão térmica até 300°C. Como todo equipamento Fry Top Green Energy, seu grande trunfo é a retenção de calor que possibilita um corte massivo nos custos de eletricidade da cozinha profissional.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/09/FT_807_EL_monoblocco-2048x1847.jpg",
                Category = "Frytop Green Energy",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "800, 700, 900",
                    HobDimensions = "720x510",
                    Voltage = "380 - 415 V 3N - 50/60 Hz / 220 - 240V 3 - 50/60Hz",
                    ElectricPower = "5.6",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "135",
                    PackagingVolume = "0.61",
                    Construction = "Aço Inox",
                    WaterConnection = "-",
                    LoadingWater = "-",
                    HeartProbe = "Opcional"
                }
            },new Product
            {
                Id = 19,
                Name = "FT 807 EL TOP",
                ShortDescription = "Digital electric countertop griddle of 80 by 70 cm with energy savings technology.",
                FullDescription = "The peculiarity of Arris Fry-top Green Energy is due to thermal inertia, which is conveyed to the cooking surface by the heating elements. The heating elements, once heated up, only consume the amount of energy necessary to stay on the selected temperature. Our special technology allows the griddle to have a 25%-30% lower maximum consumption in comparison to an appliance with the same dimensions in the market. Thanks to the particular composition of the materials and to the thermal characteristics, it is even possible to have an energy saving up to 50%.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/Frytop_807-Top.jpg",
                Category = "Frytop Green Energy",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "800, 700, 400",
                    HobDimensions = "720x510",
                    Voltage = "380 - 415 V 3N - 50/60 Hz 220 - 240V 3 - 50/60Hz",
                    ElectricPower = "5.6",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "120",
                    PackagingVolume = "0.47",
                    Construction = "Stainless steel",
                    WaterConnection = "-",
                    LoadingWater = "-",
                    HeartProbe = "Optional"
                }
            },

            new Product
            {
                Id = 20,
                Name = "FT 809 EL",
                ShortDescription = "Grelhador elétrico digital de piso (freestanding) - 2 zonas de cocção - Profundidade 90cm.",
                FullDescription = "O equipamento robusto para alta demanda em linhas de 90 cm de profundidade. Com placa térmica de 720x710 mm e duas zonas de temperatura, o FT 809 EL é um tanque de guerra na cozinha profissional. Seu painel digital mantém os 300°C com consumo incrivelmente baixo graças aos materiais especiais da tecnologia Green Energy, trazendo rentabilidade e performance sem limites.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/FT_809_EL_monoblocco-2048x1775.jpg",
                Category = "Frytop Green Energy",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "800, 900, 900",
                    HobDimensions = "720x710",
                    Voltage = "380 - 415 V 3N - 50/60 Hz / 220 - 240V 3 - 50/60Hz",
                    ElectricPower = "8.3",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "155",
                    PackagingVolume = "0.78",
                    Construction = "Aço Inox",
                    WaterConnection = "-",
                    LoadingWater = "-",
                    HeartProbe = "Opcional"
                }
            },
            new Product
            {
                Id = 21,
                Name = "FT 809 EL TOP",
                ShortDescription = "Grelhador elétrico digital de bancada (countertop) - 2 zonas de cocção - Profundidade 90cm.",
                FullDescription = "O grelhador de bancada definitivo para cozinhas de alto volume. O FT 809 EL TOP oferece as mesmas 2 zonas independentes e a vasta chapa de 720x710 mm do modelo de piso, otimizado para tampos e refrigeração inferior. Sua eficiência térmica é capaz de abater o consumo elétrico significativamente, tornando-o um pilar essencial na filosofia Fry Top Green Energy de sustentabilidade e economia corporativa.",
                ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/Frytop_809-Top.jpg",
                Category = "Frytop Green Energy",
                TechnicalSpec = new TechnicalSpec
                {
                    ProductDimensions = "800, 900, 400",
                    HobDimensions = "720x710",
                    Voltage = "380 - 415 V 3N - 50/60 Hz / 220 - 240V 3 - 50/60Hz",
                    ElectricPower = "8.3",
                    GasPower = "-",
                    GasConsumption = "-",
                    GrossWeight = "140",
                    PackagingVolume = "0.6",
                    Construction = "Aço Inox",
                    WaterConnection = "-",
                    LoadingWater = "-",
                    HeartProbe = "Opcional"
                }
            }



        };

        public Task<List<Product>> GetAllAsync() =>
            Task.FromResult(_products.Where(p => p.IsAvailable).ToList());

        public Task<Product?> GetByIdAsync(int id) =>
            Task.FromResult(_products.FirstOrDefault(p => p.Id == id));

        public Task<List<Product>> GetByCategoryAsync(string category) =>
            Task.FromResult(_products
                .Where(p => p.IsAvailable && p.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                .ToList());

        public Task<List<Product>> SearchAsync(string term) =>
            Task.FromResult(_products
                .Where(p => p.IsAvailable &&
                    (p.Name.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                     p.ShortDescription.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                     p.Category.Contains(term, StringComparison.OrdinalIgnoreCase)))
                .ToList());

        public Task<List<string>> GetCategoriesAsync() =>
            Task.FromResult(_products
                .Where(p => p.IsAvailable)
                .Select(p => p.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToList());

        public Task<List<Product>> GetRelatedAsync(int productId, int count = 3)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if (product == null) return Task.FromResult(new List<Product>());

            var related = _products
                .Where(p => p.Id != productId && p.IsAvailable && p.Category == product.Category)
                .Take(count)
                .ToList();

            if (related.Count < count)
            {
                var others = _products
                    .Where(p => p.Id != productId && p.IsAvailable && p.Category != product.Category)
                    .Take(count - related.Count);
                related.AddRange(others);
            }

            return Task.FromResult(related);
        }
    }
}