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
            },

new Product
{
    Id = 22,
    Name = "GE 1207 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 3 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada de 120 por 70 cm com tecnologia patenteada Grillvapor. Permite preparar grandes quantidades de alimentos com excelente sabor, aproveitando a facilidade de uso de um grelhador elétrico com sistema de aquecimento integrado. Permite também o uso da sonda de temperatura de núcleo, grelhando com perfeição sempre. O GE 1207 EL faz parte da linha Grillvapor EL, combinando facilidade de uso e eficiência com resultados máximos.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/1207-el-125.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1195, 700, 440",
        HobDimensions = "1195x530",
        Voltage = "400V 3N - 22,6A - 50/60Hz / 230V 3 - 39,3A - 50/60Hz",
        ElectricPower = "15.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "117",
        PackagingVolume = "0.69",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 23,
    Name = "GE 1217 EL",
    ShortDescription = "Grelhador elétrico digital de piso - 3 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de piso de 120 por 70 cm com tecnologia patenteada Grillvapor. Permite preparar grandes quantidades de alimentos com excelente sabor, aproveitando a facilidade de uso de um grelhador elétrico com sistema de aquecimento integrado. O GE 1217 EL combina facilidade de uso e eficiência com resultados máximos.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GE1217-EL.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1195, 700, 850",
        HobDimensions = "1195x530",
        Voltage = "400V 3N - 22,6A - 50/60Hz / 230V 3 - 39,3A - 50/60Hz",
        ElectricPower = "15.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "132",
        PackagingVolume = "0.9",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Automático",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 24,
    Name = "GE 407 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada de 40 por 70 cm com tecnologia patenteada Grillvapor. Permite preparar alimentos grelhados com excelente sabor, aproveitando a facilidade de uso de um grelhador elétrico com sistema de aquecimento integrado. O GE 407 EL faz parte da linha Grillvapor EL, combinando facilidade de uso e eficiência com resultados máximos.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge407el_serie700.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 440",
        HobDimensions = "390x530",
        Voltage = "400V 3N - 7,5A - 50/60Hz / 230V 3 - 13A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "50",
        PackagingVolume = "0.26",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 25,
    Name = "GE 407 EL/M TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 1 zona de cocção - Monofásico.",
    FullDescription = "Grelhador elétrico digital de bancada de 40 por 70 cm com tecnologia patenteada Grillvapor. Ideal para cozinhas com fornecimento de energia monofásica, permitindo preparar alimentos grelhados com excelente sabor e aproveitando a facilidade do aquecimento integrado.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge407el_serie700-M.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 440",
        HobDimensions = "390x530",
        Voltage = "230V - 22,6A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "50",
        PackagingVolume = "0.26",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 26,
    Name = "GE 409 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada de 40 por 90 cm com tecnologia patenteada Grillvapor. Com maior profundidade, permite preparar alimentos grelhados de forma eficiente e controlada com a sonda de temperatura de núcleo.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge409el_serie900.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 900, 440",
        HobDimensions = "390x730",
        Voltage = "400V 3N - 11,3A - 50/60Hz / 230V 3 - 19,6A - 50/60Hz",
        ElectricPower = "7.8",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "57",
        PackagingVolume = "0.33",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 27,
    Name = "GE 417 EL",
    ShortDescription = "Grelhador elétrico digital de piso - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de piso de 40 por 70 cm com tecnologia patenteada Grillvapor. Permite preparar ótimos alimentos grelhados com a facilidade do aquecimento elétrico integrado e abastecimento de água automático.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge417el_serie700.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 850",
        HobDimensions = "390x530",
        Voltage = "400V 3N - 7,5A - 50/60Hz / 230V 3 - 13A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "61",
        PackagingVolume = "0.35",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Automático",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 28,
    Name = "GE 417 EL/M",
    ShortDescription = "Grelhador elétrico digital de piso - 1 zona de cocção - Monofásico.",
    FullDescription = "Grelhador elétrico digital de piso de 40 por 70 cm adaptado para cozinhas com fornecimento monofásico. Mantém toda a tecnologia Grillvapor e facilidade de operação da linha EL.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge417el_serie700-M.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 850",
        HobDimensions = "390x530",
        Voltage = "230V - 22,6A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "61",
        PackagingVolume = "0.35",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Automático",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 29,
    Name = "GE 419 EL",
    ShortDescription = "Grelhador elétrico digital de piso - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de piso de 40 por 90 cm. Sua profundidade estendida e o sistema de aquecimento elétrico integrado garantem resultados máximos em cada serviço.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge419el_serie-900.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 900, 850",
        HobDimensions = "390x730",
        Voltage = "400V 3N - 11,3A - 50/60Hz / 230V 3 - 19,6A - 50/60Hz",
        ElectricPower = "7.8",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "73",
        PackagingVolume = "0.44",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Automático",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 30,
    Name = "GE 807 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada de 80 por 70 cm com 2 zonas independentes. O sistema Grillvapor integrado permite grelhados com sabor autêntico de forma prática e limpa.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge807el_serie700.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 700, 440",
        HobDimensions = "760x530",
        Voltage = "400V 3N - 15A - 50/60Hz / 230V 3 - 26,2A - 50/60Hz",
        ElectricPower = "10.4",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "83",
        PackagingVolume = "0.47",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 31,
    Name = "GE 809 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada de 80 por 90 cm. Oferece grande superfície para altos volumes de produção, aliando a tecnologia patenteada de vapor e aquecimento elétrico da linha EL.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge809el_serie900.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 900, 440",
        HobDimensions = "760x730",
        Voltage = "400V 3N - 22,6A - 50/60Hz / 230V 3 - 32,3A - 50/60Hz",
        ElectricPower = "15.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "98",
        PackagingVolume = "0.6",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 32,
    Name = "GE 817 EL",
    ShortDescription = "Grelhador elétrico digital de piso - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de piso de 80 por 70 cm. Equipamento robusto de duas zonas com abastecimento automático de água e sistema de precisão térmica Grillvapor.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge817el_serie700.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 700, 850",
        HobDimensions = "760x530",
        Voltage = "400V 3N - 15A - 50/60Hz / 230V 3 - 26,2A - 50/60Hz",
        ElectricPower = "10.4",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "98",
        PackagingVolume = "0.62",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Automático",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 33,
    Name = "GE 819 EL",
    ShortDescription = "Grelhador elétrico digital de piso - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de piso profundo (80 por 90 cm). Projetado para alta performance em foodservice, combinando grande capacidade de cocção e sonda de controle opcional.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge819el_serie900.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 900, 850",
        HobDimensions = "760x730",
        Voltage = "400V 3N - 22,6A - 50/60Hz / 230V 3 - 32,3A - 50/60Hz",
        ElectricPower = "15.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "113",
        PackagingVolume = "0.78",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Automático",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 34,
    Name = "GV 1207 EL TOP",
    ShortDescription = "Grelhador elétrico robusto de bancada - 3 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico robusto de bancada de 120 por 70 cm com tecnologia patenteada Grillvapor. Ideal para preparos em larga escala, entregando a confiabilidade clássica da Arris no aquecimento elétrico.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/1207-el-anlogico.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1195, 700, 440",
        HobDimensions = "1195x530",
        Voltage = "400V 3N - 22,5A - 50/60Hz / 230V 3 - 39,2A - 50/60Hz",
        ElectricPower = "15.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "117",
        PackagingVolume = "0.69",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 35,
    Name = "GV 1217 EL",
    ShortDescription = "Grelhador elétrico robusto de piso - 3 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico robusto de piso de 120 por 70 cm. Equipamento de grande porte focado na linha clássica Grillvapor EL, com abastecimento manual e estrutura sólida em aço inox.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/1217-EL-047.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1195, 700, 850",
        HobDimensions = "1195x530",
        Voltage = "400V 3N - 22,5A - 50/60Hz / 230V 3 - 39,2A - 50/60Hz",
        ElectricPower = "15.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "132",
        PackagingVolume = "0.9",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 36,
    Name = "GV 407 EL TOP",
    ShortDescription = "Grelhador elétrico robusto de bancada - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico robusto de bancada de 40 por 70 cm. Leva a famosa tecnologia patenteada Grillvapor para espaços compactos, mantendo o excelente resultado de grelha.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/407-el-196.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 440",
        HobDimensions = "390x530",
        Voltage = "400V 3N - 7,5A - 50/60Hz / 230V 3 - 13A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "50",
        PackagingVolume = "0.26",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 37,
    Name = "GV 407 EL/M TOP",
    ShortDescription = "Grelhador elétrico robusto de bancada - 1 zona de cocção - Monofásico.",
    FullDescription = "Versão monofásica do robusto grelhador de bancada de 40 por 70 cm. A solução perfeita para restaurantes com rede elétrica monofásica que exigem o desempenho do Grillvapor.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/407-el-196-M.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 440",
        HobDimensions = "390x530",
        Voltage = "230V - 22,6A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "50",
        PackagingVolume = "0.26",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 38,
    Name = "GV 409 EL TOP",
    ShortDescription = "Grelhador elétrico robusto de bancada - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico robusto de bancada de 40 por 90 cm. A profundidade estendida garante maior área útil para o chef, mantendo a eficiência do sistema de vapor e calor integrado.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/409-el-top-190.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 900, 440",
        HobDimensions = "390x730",
        Voltage = "400V 3N - 11,3A - 50/60Hz / 230V 3 - 19,6A - 50/60Hz",
        ElectricPower = "7.8",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "57",
        PackagingVolume = "0.33",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 39,
    Name = "GV 417 EL",
    ShortDescription = "Grelhador elétrico robusto de piso - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico robusto de piso de 40 por 70 cm. Equipamento resistente e eficiente, projetado para operar continuamente entregando carnes e vegetais suculentos.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/417-el-196.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 850",
        HobDimensions = "390x530",
        Voltage = "400V 3N - 7,5A - 50/60Hz / 230V 3 - 13A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "61",
        PackagingVolume = "0.35",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 40,
    Name = "GV 417 EL/M",
    ShortDescription = "Grelhador elétrico robusto de piso - 1 zona de cocção - Monofásico.",
    FullDescription = "Grelhador elétrico robusto de piso de 40 por 70 cm em versão monofásica. Flexibilidade de instalação sem perder a força estrutural e a tecnologia Grillvapor.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/417-el-196-M.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 850",
        HobDimensions = "390x530",
        Voltage = "230V - 22,6A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "61",
        PackagingVolume = "0.35",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 41,
    Name = "GV 419 EL",
    ShortDescription = "Grelhador elétrico robusto de piso - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico robusto de piso de 40 por 90 cm. A solução ideal para otimizar layouts de cozinha verticalizando a produção na mesma estação de trabalho.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/gv-419-el-655.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 900, 850",
        HobDimensions = "390x730",
        Voltage = "400V 3N - 11,3A - 50/60Hz / 230V 3 - 19,6A - 50/60Hz",
        ElectricPower = "7.8",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "73",
        PackagingVolume = "0.44",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 42,
    Name = "GV 807 EL TOP",
    ShortDescription = "Grelhador elétrico robusto de bancada - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico robusto de bancada de 80 por 70 cm. Duas zonas de cocção que permitem diversificar o cardápio usando o sistema patenteado de vapor da Arris.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/807-el-617.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 700, 440",
        HobDimensions = "760x530",
        Voltage = "400V 3N - 15A - 50/60Hz / 230V 3 - 26,1A - 50/60Hz",
        ElectricPower = "10.4",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "83",
        PackagingVolume = "0.47",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 43,
    Name = "GV 809 EL TOP",
    ShortDescription = "Grelhador elétrico robusto de bancada - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico robusto de bancada de 80 por 90 cm. Uma força de trabalho para restaurantes de alto volume que buscam padronização e suculência nas carnes.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/809-el114.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 900, 440",
        HobDimensions = "760x730",
        Voltage = "400V 3N - 22,5A - 50/60Hz / 230V 3 - 32,2A - 50/60Hz",
        ElectricPower = "15.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "98",
        PackagingVolume = "0.6",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 44,
    Name = "GV 817 EL",
    ShortDescription = "Grelhador elétrico robusto de piso - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico robusto de piso de 80 por 70 cm. A arquitetura clássica da linha Grillvapor aplicada a um modelo versátil e potente para as operações do dia a dia.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/817-el-622.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 700, 850",
        HobDimensions = "760x530",
        Voltage = "400V 3N - 15A - 50/60Hz / 230V 3 - 26,1A - 50/60Hz",
        ElectricPower = "10.4",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "98",
        PackagingVolume = "0.62",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 45,
    Name = "GV 819 EL",
    ShortDescription = "Grelhador elétrico robusto de piso - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico robusto de piso de 80 por 90 cm. Máxima capacidade de produção aliada à facilidade de operação e excelente retenção do peso dos grelhados.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/gv-819-el-204.jpg",
    Category = "Grillvapor EL",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 900, 850",
        HobDimensions = "760x730",
        Voltage = "400V 3N - 22,5A - 50/60Hz / 230V 3 - 32,2A - 50/60Hz",
        ElectricPower = "15.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "113",
        PackagingVolume = "0.78",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
// --- INÍCIO DA CATEGORIA GRILLVAPOR EL DIGIT ---

new Product
{
    Id = 46,
    Name = "FT 1207EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 3 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada de 120 por 70 cm com tecnologia de economia de energia. Construção e tecnologia especiais que resultam em redução do consumo elétrico mesmo atingindo temperaturas de cerca de 300°C. O FT 1207 EL TOP faz parte da linha Fry Top Green Energy, projetado para se pagar através da economia de energia em um curto espaço de tempo.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/FT_1207_EL_top-2048x1424.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
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
    Id = 47,
    Name = "FT 407 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada de 40 por 70 cm com tecnologia de economia de energia. A engenharia térmica avançada permite atingir cerca de 300°C com baixo consumo. O FT 407 EL TOP integra a linha Fry Top Green Energy, unindo performance profissional à sustentabilidade.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/Frytop_407-Top.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
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
    Id = 48,
    Name = "FT 407 EL/M TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 1 zona de cocção - Monofásico.",
    FullDescription = "Versão monofásica do grelhador elétrico digital de bancada de 40 por 70 cm. Traz a tecnologia de economia de energia Fry Top Green Energy para cozinhas com rede elétrica convencional, mantendo a capacidade de atingir altas temperaturas com baixo consumo.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/Frytop_407-Top-M.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
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
    Id = 49,
    Name = "FT 409 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada com profundidade estendida (40 por 90 cm). Combina uma área útil maior com a tecnologia sustentável da linha Fry Top Green Energy, alcançando 300°C com eficiência térmica superior.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/Frytop_409-Top.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
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
    Id = 50,
    Name = "FT 807 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada de 80 por 70 cm com dupla zona de cocção. Projetado para altos volumes operacionais, utiliza a tecnologia Green Energy para reduzir os custos com energia elétrica sem comprometer a temperatura de trabalho.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/Frytop_807-Top.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 700, 400",
        HobDimensions = "720x510",
        Voltage = "380 - 415 V 3N - 50/60 Hz / 220 - 240V 3 - 50/60Hz",
        ElectricPower = "5.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "120",
        PackagingVolume = "0.47",
        Construction = "Aço Inox",
        WaterConnection = "-",
        LoadingWater = "-",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 51,
    Name = "FT 809 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 2 zonas de cocção - Trifásico.",
    FullDescription = "O grelhador de bancada definitivo para cozinhas de alto volume (80 por 90 cm). Oferece extensa superfície de preparo e máxima economia graças à tecnologia Fry Top Green Energy, garantindo um rápido retorno do investimento.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/Frytop_809-Top.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
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
},
new Product
{
    Id = 52,
    Name = "GE 1207 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 3 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada de 120 por 70 cm com tecnologia patenteada Grillvapor. Permite preparar grandes quantidades de alimentos com excelente sabor, integrando um potente sistema de aquecimento elétrico e sonda de núcleo opcional.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/1207-el-125.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1195, 700, 440",
        HobDimensions = "1195x530",
        Voltage = "400V 3N - 22,6A - 50/60Hz / 230V 3 - 39,3A - 50/60Hz",
        ElectricPower = "15.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "117",
        PackagingVolume = "0.69",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 53,
    Name = "GE 1217 EL",
    ShortDescription = "Grelhador elétrico digital de piso - 3 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de piso de 120 por 70 cm com tecnologia Grillvapor. Une alta capacidade produtiva ao sistema de abastecimento automático de água, facilitando o uso contínuo em grandes cozinhas comerciais.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GE1217-EL.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1195, 700, 850",
        HobDimensions = "1195x530",
        Voltage = "400V 3N - 22,6A - 50/60Hz / 230V 3 - 39,3A - 50/60Hz",
        ElectricPower = "15.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "132",
        PackagingVolume = "0.9",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Automático",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 54,
    Name = "GE 407 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada compacto (40 por 70 cm). Utiliza a inovação Grillvapor para reter a suculência das carnes através do sistema elétrico integrado e bandeja umidificadora.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge407el_serie700.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 440",
        HobDimensions = "390x530",
        Voltage = "400V 3N - 7,5A - 50/60Hz / 230V 3 - 13A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "50",
        PackagingVolume = "0.26",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 55,
    Name = "GE 407 EL/M TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 1 zona de cocção - Monofásico.",
    FullDescription = "Versão monofásica do grelhador compacto de bancada (40 por 70 cm). Ideal para operações que possuem limitações elétricas, entregando a mesma perfeição térmica da linha Grillvapor.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge407el_serie700-M.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 440",
        HobDimensions = "390x530",
        Voltage = "230V - 22,6A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "50",
        PackagingVolume = "0.26",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 56,
    Name = "GE 409 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada profundo (40 por 90 cm). Facilita o enfileiramento de proteínas na grelha, otimizando o fluxo de cocção com a precisão da tecnologia Grillvapor.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge409el_serie900.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 900, 440",
        HobDimensions = "390x730",
        Voltage = "400V 3N - 11,3A - 50/60Hz / 230V 3 - 19,6A - 50/60Hz",
        ElectricPower = "7.8",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "57",
        PackagingVolume = "0.33",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 57,
    Name = "GE 417 EL",
    ShortDescription = "Grelhador elétrico digital de piso - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de piso (40 por 70 cm). Conta com abastecimento automático de água, garantindo uma produção contínua sem necessidade de paradas para reabastecimento do sistema Grillvapor.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge417el_serie700.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 850",
        HobDimensions = "390x530",
        Voltage = "400V 3N - 7,5A - 50/60Hz / 230V 3 - 13A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "61",
        PackagingVolume = "0.35",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Automático",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 58,
    Name = "GE 417 EL/M",
    ShortDescription = "Grelhador elétrico digital de piso - 1 zona de cocção - Monofásico.",
    FullDescription = "Grelhador elétrico digital de piso monofásico (40 por 70 cm). Mantém todas as vantagens de ergonomia do modelo de piso e controle inteligente da tecnologia patenteada da Arris.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge417el_serie700-M.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 850",
        HobDimensions = "390x530",
        Voltage = "230V - 22,6A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "61",
        PackagingVolume = "0.35",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Automático",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 59,
    Name = "GE 419 EL",
    ShortDescription = "Grelhador elétrico digital de piso - 1 zona de cocção - Trifásico.",
    FullDescription = "Modelo de piso de profundidade avançada (40 por 90 cm). Desenvolvido para máxima eficiência na estação de grelhados, compatível com a sonda de núcleo opcional para controle perfeito.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge419el_serie-900.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 900, 850",
        HobDimensions = "390x730",
        Voltage = "400V 3N - 11,3A - 50/60Hz / 230V 3 - 19,6A - 50/60Hz",
        ElectricPower = "7.8",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "73",
        PackagingVolume = "0.44",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Automático",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 60,
    Name = "GE 807 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada (80 por 70 cm) com sistema duplo de aquecimento. Produtividade em larga escala com a vantagem da limpeza simplificada do sistema Grillvapor.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge807el_serie700.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 700, 440",
        HobDimensions = "760x530",
        Voltage = "400V 3N - 15A - 50/60Hz / 230V 3 - 26,2A - 50/60Hz",
        ElectricPower = "10.4",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "83",
        PackagingVolume = "0.47",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 61,
    Name = "GE 809 EL TOP",
    ShortDescription = "Grelhador elétrico digital de bancada - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de bancada pesado (80 por 90 cm). Oferece áreas independentes para múltiplos preparos, selando e cozinhando com a maciez proporcionada pelo vapor integrado.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge809el_serie900.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 900, 440",
        HobDimensions = "760x730",
        Voltage = "400V 3N - 22,6A - 50/60Hz / 230V 3 - 32,3A - 50/60Hz",
        ElectricPower = "15.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "98",
        PackagingVolume = "0.6",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 62,
    Name = "GE 817 EL",
    ShortDescription = "Grelhador elétrico digital de piso - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico digital de piso (80 por 70 cm). Estrutura completa em aço inox AISI 304 com abastecimento de água automatizado, a escolha segura das cozinhas profissionais de alto fluxo.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge817el_serie700.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 700, 850",
        HobDimensions = "760x530",
        Voltage = "400V 3N - 15A - 50/60Hz / 230V 3 - 26,2A - 50/60Hz",
        ElectricPower = "10.4",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "98",
        PackagingVolume = "0.62",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Automático",
        HeartProbe = "Opcional"
    }
},
new Product
{
    Id = 63,
    Name = "GE 819 EL",
    ShortDescription = "Grelhador elétrico digital de piso - 2 zonas de cocção - Trifásico.",
    FullDescription = "O topo de linha digital para grandes preparos (80 por 90 cm). Alta potência térmica com 2 zonas controláveis e vaporização inteligente, reduzindo a quebra de peso dos alimentos durante o serviço.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/ge819el_serie900.jpg",
    Category = "Grillvapor El Digit",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 900, 850",
        HobDimensions = "760x730",
        Voltage = "400V 3N - 22,6A - 50/60Hz / 230V 3 - 32,3A - 50/60Hz",
        ElectricPower = "15.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "113",
        PackagingVolume = "0.78",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Automático",
        HeartProbe = "Opcional"
    }
},
// --- INÍCIO DA CATEGORIA GRILLVAPOR GAS ---

new Product
{
    Id = 64,
    Name = "GV 1207",
    ShortDescription = "Grelhador a gás de bancada - 3 zonas de cocção.",
    FullDescription = "Grelhador a gás robusto de bancada de 120 por 70 cm com tecnologia patenteada Grillvapor. Este equipamento é resistente, confiável, fácil de usar e proporciona aquele sabor de grelhado perfeito sempre, ideal para cozinhas que exigem altos níveis de produção. O GV 1207 faz parte da linha Grillvapor Gas, combinando máxima confiabilidade com resultados máximos.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/gv1207-CATALOGO.jpg",
    Category = "Grillvapor Gas",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1200, 700, 440",
        HobDimensions = "1155x470",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "31.5",
        GasConsumption = "3,33 / 2,46",
        GrossWeight = "117",
        PackagingVolume = "0.69",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 65,
    Name = "GV 1209",
    ShortDescription = "Grelhador a gás de bancada - 3 zonas de cocção.",
    FullDescription = "Grelhador a gás robusto de bancada de 120 por 90 cm com tecnologia patenteada Grillvapor. Amplo e confiável, é fácil de operar e garante o verdadeiro sabor de grelhado a cada uso em operações de alto volume de produção.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/gv1209-CATALOGO.jpg",
    Category = "Grillvapor Gas",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1200, 900, 440",
        HobDimensions = "1155x670",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "39",
        GasConsumption = "4,13 / 3,05",
        GrossWeight = "137",
        PackagingVolume = "0.87",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 66,
    Name = "GV 1217",
    ShortDescription = "Grelhador a gás de piso - 3 zonas de cocção.",
    FullDescription = "Grelhador a gás robusto de piso de 120 por 70 cm com tecnologia Grillvapor. Projetado para as demandas mais rigorosas do foodservice, alia durabilidade estrutural à perfeição do preparo a gás, suportando intenso ritmo de trabalho.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/1217-047.jpg",
    Category = "Grillvapor Gas",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1200, 700, 850",
        HobDimensions = "1155x470",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "31.5",
        GasConsumption = "3,33 / 2,46",
        GrossWeight = "132",
        PackagingVolume = "0.9",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 67,
    Name = "GV 1219",
    ShortDescription = "Grelhador a gás de piso - 3 zonas de cocção.",
    FullDescription = "Grelhador a gás robusto de piso de 120 por 90 cm com tecnologia patenteada Grillvapor. O gigante da linha a gás, espaçoso e incansável, preparado para fornecer grandes produções de grelhados com a chancela de qualidade da Arris.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/1219-gas-663.jpg",
    Category = "Grillvapor Gas",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1200, 900, 850",
        HobDimensions = "1155x670",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "39",
        GasConsumption = "4,13 / 3,05",
        GrossWeight = "153",
        PackagingVolume = "1.15",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 68,
    Name = "GV 407",
    ShortDescription = "Grelhador a gás de bancada - 1 zona de cocção.",
    FullDescription = "Grelhador a gás de bancada de 40 por 70 cm. Compacto, porém extremamente robusto, oferece a reconhecida tecnologia Grillvapor para espaços menores, garantindo suculência impecável no dia a dia.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/407-gv-582.jpg",
    Category = "Grillvapor Gas",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 440",
        HobDimensions = "390x470",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "10.5",
        GasConsumption = "1,10 / 0,82",
        GrossWeight = "50",
        PackagingVolume = "0.26",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 69,
    Name = "GV 409",
    ShortDescription = "Grelhador a gás de bancada - 1 zona de cocção.",
    FullDescription = "Grelhador a gás de bancada profundo de 40 por 90 cm. Expande a capacidade de enfileiramento de alimentos na cocção sem ocupar a largura da bancada, entregando o resultado clássico do Grillvapor a gás.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/409-gas-102.jpg",
    Category = "Grillvapor Gas",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 900, 440",
        HobDimensions = "390x670",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "13",
        GasConsumption = "1,37 / 2,46",
        GrossWeight = "57",
        PackagingVolume = "0.33",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 70,
    Name = "GV 417",
    ShortDescription = "Grelhador a gás de piso - 1 zona de cocção.",
    FullDescription = "Grelhador a gás de piso de 40 por 70 cm. Solução eficiente que não requer apoio de bancada, aliando praticidade de manuseio e facilidade de limpeza ao poder da tecnologia patenteada da Arris.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/417-gv-635.jpg",
    Category = "Grillvapor Gas",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 850",
        HobDimensions = "390x470",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "10.5",
        GasConsumption = "1,10 / 0,82",
        GrossWeight = "61",
        PackagingVolume = "0.35",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 71,
    Name = "GV 419",
    ShortDescription = "Grelhador a gás de piso - 1 zona de cocção.",
    FullDescription = "Grelhador a gás de piso de 40 por 90 cm. Estrutura profunda em aço inox que oferece ótima performance térmica, compondo perfeitamente ilhas de cocção industriais de alto desempenho.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/419-gas-077.jpg",
    Category = "Grillvapor Gas",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 900, 850",
        HobDimensions = "390x670",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "13",
        GasConsumption = "1,37 / 2,46",
        GrossWeight = "73",
        PackagingVolume = "0.44",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 72,
    Name = "GV 807",
    ShortDescription = "Grelhador a gás de bancada - 2 zonas de cocção.",
    FullDescription = "Grelhador a gás robusto de bancada de 80 por 70 cm. Equipamento versátil com duas zonas independentes, ideal para controlar temperaturas diferentes e garantir grelhados uniformes e sem misturas.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/807-gas-top.jpg",
    Category = "Grillvapor Gas",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 700, 440",
        HobDimensions = "770x470",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "21",
        GasConsumption = "2,22 / 1,64",
        GrossWeight = "83",
        PackagingVolume = "0.47",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 73,
    Name = "GV 809",
    ShortDescription = "Grelhador a gás de bancada - 2 zonas de cocção.",
    FullDescription = "Grelhador a gás de bancada de 80 por 90 cm com tecnologia patenteada Grillvapor. Preparado para aguentar o ritmo frenético da cozinha, otimizando o consumo de gás e garantindo suculência.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/809-gas-090.jpg",
    Category = "Grillvapor Gas",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 900, 440",
        HobDimensions = "760x670",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "26",
        GasConsumption = "2,75 / 2,03",
        GrossWeight = "98",
        PackagingVolume = "0.6",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 74,
    Name = "GV 817",
    ShortDescription = "Grelhador a gás de piso - 2 zonas de cocção.",
    FullDescription = "Grelhador a gás robusto de piso de 80 por 70 cm. Oferece dupla área de cocção aliada à conveniência de um chassi resistente e preparado para lidar com altos volumes de gordura através da água na gaveta.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/817-gv-604.jpg",
    Category = "Grillvapor Gas",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 700, 850",
        HobDimensions = "770x470",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "21",
        GasConsumption = "2,22 / 1,64",
        GrossWeight = "98",
        PackagingVolume = "0.62",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 75,
    Name = "GV 819",
    ShortDescription = "Grelhador a gás de piso - 2 zonas de cocção.",
    FullDescription = "Grelhador a gás robusto de piso de 80 por 90 cm com tecnologia Grillvapor. Sua alta potência e confiabilidade fazem dele o equipamento indispensável para churrascarias e restaurantes com foco em carnes.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/819-gasi-071.jpg",
    Category = "Grillvapor Gas",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 900, 850",
        HobDimensions = "760x670",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "26",
        GasConsumption = "2,75 / 2,03",
        GrossWeight = "113",
        PackagingVolume = "0.78",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
// --- FIM DA CATEGORIA GRILLVAPOR GAS ---
// --- INÍCIO DA CATEGORIA GRILLVAPOR GAS POWER ---

new Product
{
    Id = 76,
    Name = "GV 1207 P",
    ShortDescription = "Grelhador a gás de bancada extrapotente - 3 zonas de cocção.",
    FullDescription = "Grelhador a gás extrapotente de bancada de 120 por 70 cm com tecnologia patenteada Grillvapor. Um equipamento grande, incrivelmente potente e confiável, desenvolvido especialmente para grandes cortes e tipos especiais de carne que exigem temperaturas de grelha extremamente altas. O GV 1207 P faz parte da linha Grillvapor Gas Power, combinando máxima confiabilidade com resultados supremos.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV1207-P-TOP.jpg",
    Category = "Grillvapor Gas Power",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1200, 700, 440",
        HobDimensions = "1155x470",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "31.5",
        GasConsumption = "3,33 / 2,46",
        GrossWeight = "117",
        PackagingVolume = "0.69",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 77,
    Name = "GV 1209 P",
    ShortDescription = "Grelhador a gás de bancada extrapotente - 3 zonas de cocção.",
    FullDescription = "Grelhador a gás extrapotente de bancada de 120 por 90 cm. Com área de cocção expandida, este gigante entrega uma potência bruta invejável, desenhado para selar carnes espessas e cortes nobres sob altíssima temperatura com o benefício da tecnologia Grillvapor.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV_1209_P_TOP.jpg",
    Category = "Grillvapor Gas Power",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1200, 900, 440",
        HobDimensions = "1155x670",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "39",
        GasConsumption = "4,13 / 3,05",
        GrossWeight = "137",
        PackagingVolume = "0.87",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 78,
    Name = "GV 1217 P",
    ShortDescription = "Grelhador a gás de piso extrapotente - 3 zonas de cocção.",
    FullDescription = "Grelhador a gás extrapotente de piso de 120 por 70 cm com tecnologia Grillvapor. Base robusta, poder de fogo agressivo e controle total sobre 3 zonas de cocção, ideal para parrillas e churrascarias de alto volume que buscam a crosta perfeita na carne.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV_1217_P.jpg",
    Category = "Grillvapor Gas Power",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1200, 700, 850",
        HobDimensions = "1155x470",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "31.5",
        GasConsumption = "3,33 / 2,46",
        GrossWeight = "132",
        PackagingVolume = "0.9",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 79,
    Name = "GV 1219 P",
    ShortDescription = "Grelhador a gás de piso extrapotente - 3 zonas de cocção.",
    FullDescription = "O topo de linha absoluto da força bruta. Grelhador a gás extrapotente de piso de 120 por 90 cm. Oferece a máxima capacidade de produção térmica da linha Grillvapor Gas Power, preparado para extrair o melhor sabor de grandes cortes.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV_1219_P.jpg",
    Category = "Grillvapor Gas Power",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1200, 900, 850",
        HobDimensions = "1155x670",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "39",
        GasConsumption = "4,13 / 3,05",
        GrossWeight = "153",
        PackagingVolume = "1.15",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 80,
    Name = "GV 407 P",
    ShortDescription = "Grelhador a gás de bancada extrapotente - 1 zona de cocção.",
    FullDescription = "Grelhador a gás extrapotente de bancada de 40 por 70 cm. Compacto, mas não se engane: possui um poder de fogo concentrado projetado para selar carnes em temperaturas extremas usando a tecnologia patenteada Grillvapor.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV_407_P_TOP.jpg",
    Category = "Grillvapor Gas Power",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 440",
        HobDimensions = "390x470",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "10.5",
        GasConsumption = "1,10 / 0,82",
        GrossWeight = "50",
        PackagingVolume = "0.26",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 81,
    Name = "GV 409 P",
    ShortDescription = "Grelhador a gás de bancada extrapotente - 1 zona de cocção.",
    FullDescription = "Grelhador a gás extrapotente de bancada profundo (40 por 90 cm). Combina uma área de cocção otimizada com a intensidade térmica brutal necessária para cortes especiais, mantendo a suculência interna.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV_409_P_TOP.jpg",
    Category = "Grillvapor Gas Power",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 900, 440",
        HobDimensions = "390x670",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "13",
        GasConsumption = "1,37 / 2,46",
        GrossWeight = "57",
        PackagingVolume = "0.33",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 82,
    Name = "GV 417 P",
    ShortDescription = "Grelhador a gás de piso extrapotente - 1 zona de cocção.",
    FullDescription = "Grelhador a gás extrapotente de piso de 40 por 70 cm. Módulo independente altamente potente e confiável, focado em entregar altíssima temperatura para grelhados impecáveis em estações de trabalho focadas.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV_417_P.jpg",
    Category = "Grillvapor Gas Power",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 850",
        HobDimensions = "390x470",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "10.5",
        GasConsumption = "1,10 / 0,82",
        GrossWeight = "61",
        PackagingVolume = "0.35",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 83,
    Name = "GV 419 P",
    ShortDescription = "Grelhador a gás de piso extrapotente - 1 zona de cocção.",
    FullDescription = "Grelhador a gás extrapotente de piso de 40 por 90 cm. Uma torre de força bruta para cocção, desenhada para se adaptar a linhas de montagem pesadas e selar grandes pedaços de carne com facilidade.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV_419_P.jpg",
    Category = "Grillvapor Gas Power",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 900, 850",
        HobDimensions = "390x670",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "13",
        GasConsumption = "1,37 / 2,46",
        GrossWeight = "73",
        PackagingVolume = "0.44",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 84,
    Name = "GV 807 P",
    ShortDescription = "Grelhador a gás de bancada extrapotente - 2 zonas de cocção.",
    FullDescription = "Grelhador a gás extrapotente de bancada de 80 por 70 cm com tecnologia Grillvapor. Perfeito para operações de médio e alto volume que não podem abrir mão do controle duplo de áreas com extrema temperatura de contato.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV_807_P_TOP.jpg",
    Category = "Grillvapor Gas Power",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 700, 440",
        HobDimensions = "770x470",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "21",
        GasConsumption = "2,22 / 1,64",
        GrossWeight = "83",
        PackagingVolume = "0.47",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 85,
    Name = "GV 809 P",
    ShortDescription = "Grelhador a gás de bancada extrapotente - 2 zonas de cocção.",
    FullDescription = "Grelhador a gás extrapotente de bancada de 80 por 90 cm. Ampla superfície térmica capaz de atingir níveis extremos de calor para cocção rápida, reduzindo a quebra de peso da proteína em preparos superaquecidos.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV_809_P_TOP.jpg",
    Category = "Grillvapor Gas Power",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 900, 440",
        HobDimensions = "760x670",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "26",
        GasConsumption = "2,75 / 2,03",
        GrossWeight = "98",
        PackagingVolume = "0.6",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 86,
    Name = "GV 817 P",
    ShortDescription = "Grelhador a gás de piso extrapotente - 2 zonas de cocção.",
    FullDescription = "Grelhador a gás extrapotente de piso de 80 por 70 cm. Combina a confiabilidade máxima da marca Arris com resultados agressivos de grelha, entregando peças suculentas e bem seladas para cozinhas de alto fluxo.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV_817_P.jpg",
    Category = "Grillvapor Gas Power",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 700, 850",
        HobDimensions = "770x470",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "21",
        GasConsumption = "2,22 / 1,64",
        GrossWeight = "98",
        PackagingVolume = "0.62",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 87,
    Name = "GV 819 P",
    ShortDescription = "Grelhador a gás de piso extrapotente - 2 zonas de cocção.",
    FullDescription = "Grelhador a gás extrapotente de piso de 80 por 90 cm. O equipamento projetado para dominar os assados, exigindo temperaturas extra-altas de forma consistente ao longo de todo o serviço pesado em grandes operações.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV_819_P.jpg",
    Category = "Grillvapor Gas Power",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 900, 850",
        HobDimensions = "760x670",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "26",
        GasConsumption = "2,75 / 2,03",
        GrossWeight = "113",
        PackagingVolume = "0.78",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "Sim",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
// --- FIM DA CATEGORIA GRILLVAPOR GAS POWER ---
// --- INÍCIO DA CATEGORIA GRILLVAPOR COMPACT ---

new Product
{
    Id = 88,
    Name = "GV 1255",
    ShortDescription = "Grelhador a gás de bancada compacto - 3 zonas de cocção.",
    FullDescription = "Grelhador a gás de bancada de 120 por 55 cm com tecnologia patenteada Grillvapor. Devido à sua menor profundidade e alto potencial térmico, este é o grelhador ideal para cozinhas menores. É a solução perfeita para restaurantes em centros urbanos e food trucks que precisam produzir grandes quantidades de alimentos. O GV 1255 faz parte da linha Grillvapor Compact, construído para obter resultados máximos no mínimo de espaço.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/compact-1255-gas-top-338.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1200, 550, 315",
        HobDimensions = "1155x410",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "20.7",
        GasConsumption = "2,19 / 1,52",
        GrossWeight = "75",
        PackagingVolume = "0.34",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 89,
    Name = "GV 1255 EL TOP",
    ShortDescription = "Grelhador elétrico de bancada compacto - 3 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico de bancada de 120 por 55 cm com tecnologia Grillvapor. Sua profundidade reduzida o torna ideal para cozinhas restritas, como food trucks e operações em centros urbanos, sem abrir mão da capacidade de produzir em larga escala e com extrema qualidade.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/V2_compact-1255-EL-top-338.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1195, 550, 315",
        HobDimensions = "1155x380",
        Voltage = "400V 3N - 16,5A - 50/60Hz / 230V 3 - 28,6A - 50/60Hz",
        ElectricPower = "11.4",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "75",
        PackagingVolume = "0.34",
        Construction = "Aço Inox Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 90,
    Name = "GV 1270",
    ShortDescription = "Grelhador a gás de bancada rebaixado - 3 zonas de cocção.",
    FullDescription = "Grelhador a gás de bancada de 120 por 70 cm. Devido à sua altura reduzida (apenas 31,5 cm) e alto potencial, este é o equipamento ideal para ser posicionado sobre superfícies elevadas, como bases refrigeradas de chef, em cozinhas que exigem alta produção.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/compact-1270-gas-top-338.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "1200, 700, 315",
        HobDimensions = "1155x550",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "25.5",
        GasConsumption = "2,7 / 2,1",
        GrossWeight = "105",
        PackagingVolume = "0.56",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 91,
    Name = "GV 1270 EL TOP",
    ShortDescription = "Grelhador elétrico de bancada rebaixado - 3 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico de bancada de 120 por 70 cm com altura reduzida. Otimiza a ergonomia da cozinha quando instalado sobre gaveteiros refrigerados, mantendo as 3 zonas independentes e a tecnologia de vapor da linha Compact.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/V2_compact-1270-EL-top-338.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 440", 
        HobDimensions = "1195x530",
        Voltage = "400V 3N - 22,5A - 50/60Hz / 230V 3 - 39,2A - 50/60Hz",
        ElectricPower = "15.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "105",
        PackagingVolume = "0.56",
        Construction = "Aço Inox Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 92,
    Name = "GV 455",
    ShortDescription = "Grelhador a gás de bancada compacto - 1 zona de cocção.",
    FullDescription = "Grelhador a gás de bancada de 40 por 55 cm. Seu tamanho ultracompacto e alta potência fazem dele a escolha definitiva para espaços minúsculos, oferecendo aos food trucks e pequenos bistrôs o poder do Grillvapor original.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV455.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 550, 315",
        HobDimensions = "390x410",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "6.9",
        GasConsumption = "0,73 / 0,54",
        GrossWeight = "30",
        PackagingVolume = "0.13",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 93,
    Name = "GV 455 EL TOP",
    ShortDescription = "Grelhador elétrico de bancada compacto - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico de bancada de 40 por 55 cm. Solução elétrica robusta e super compacta, projetada para extrair os melhores resultados de sabor no menor espaço físico possível na linha de preparo.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV455EL.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 550, 315",
        HobDimensions = "390x380",
        Voltage = "400V 3N - 5,5A - 50/60Hz / 230V 3 - 9,5A - 50/60Hz",
        ElectricPower = "3.8",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "30",
        PackagingVolume = "0.13",
        Construction = "Aço Inox Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 94,
    Name = "GV 455 EL/M TOP",
    ShortDescription = "Grelhador elétrico de bancada compacto - 1 zona de cocção - Monofásico.",
    FullDescription = "Versão monofásica do grelhador ultracompacto (40 por 55 cm). A opção mais flexível para instalações restritas em pequenos comércios ou quiosques que buscam agregar um grelhador de qualidade premium ao menu.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV455EL-M.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 550, 315",
        HobDimensions = "390x380",
        Voltage = "230V - 16,5A - 50/60Hz",
        ElectricPower = "3.8",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "30",
        PackagingVolume = "0.13",
        Construction = "Aço Inox Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 95,
    Name = "GV 470",
    ShortDescription = "Grelhador a gás de bancada rebaixado - 1 zona de cocção.",
    FullDescription = "Grelhador a gás de bancada de 40 por 70 cm. Com apenas 31,5 cm de altura, este equipamento encaixa-se nas menores cozinhas e é perfeito para compor módulos sobre bases refrigeradas sem comprometer a postura do chef.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV470.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 315",
        HobDimensions = "390x550",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "8.5",
        GasConsumption = "0,90 / 0,70",
        GrossWeight = "35",
        PackagingVolume = "0.17",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 96,
    Name = "GV 470 EL TOP",
    ShortDescription = "Grelhador elétrico de bancada rebaixado - 1 zona de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico de bancada com altura reduzida (40 por 70 cm). Traz a retenção de calor e o sistema Grillvapor em um formato adaptado para otimizar o fluxo de montagem de pratos.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV470EL.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 315",
        HobDimensions = "390x530",
        Voltage = "400V 3N - 7,5A - 50/60Hz / 230V 3 - 13A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "40",
        PackagingVolume = "0.18",
        Construction = "Aço Inox Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 97,
    Name = "GV 470 EL/M TOP",
    ShortDescription = "Grelhador elétrico de bancada rebaixado - 1 zona de cocção - Monofásico.",
    FullDescription = "Versão monofásica do modelo elétrico rebaixado (40 por 70 cm). Oferece total versatilidade de instalação para as cozinhas mais apertadas que exigem um equipamento sobre o balcão refrigerado.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV470EL-M.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "420, 700, 315",
        HobDimensions = "390x530",
        Voltage = "230V - 22,6A - 50/60Hz",
        ElectricPower = "5.2",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "40",
        PackagingVolume = "0.18",
        Construction = "Aço Inox Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 98,
    Name = "GV 855",
    ShortDescription = "Grelhador a gás de bancada compacto - 2 zonas de cocção.",
    FullDescription = "Grelhador a gás de bancada duplo de 80 por 55 cm. Devido à sua menor profundidade, é a escolha ideal para pequenos restaurantes que têm um cardápio variado e não abrem mão da alta produção diária.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/GV855.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 550, 315",
        HobDimensions = "760x410",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "13.8",
        GasConsumption = "1,46 / 1,08",
        GrossWeight = "50",
        PackagingVolume = "0.21",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 99,
    Name = "GV 855 EL TOP",
    ShortDescription = "Grelhador elétrico de bancada compacto - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico de bancada duplo e compacto (80 por 55 cm). Entrega flexibilidade operacional e facilidade de limpeza em praças de alimentação e food trucks graças ao seu formato inteligente e potência controlada.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/el-855-163.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 550, 315",
        HobDimensions = "760x380",
        Voltage = "400V 3N - 11A - 50/60Hz / 230V 3 - 19A - 50/60Hz",
        ElectricPower = "7.6",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "50",
        PackagingVolume = "0.21",
        Construction = "Aço Inox Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 100,
    Name = "GV 870",
    ShortDescription = "Grelhador a gás de bancada rebaixado - 2 zonas de cocção.",
    FullDescription = "Grelhador a gás de bancada de 80 por 70 cm. A altura reduzida possibilita o posicionamento seguro em cima de estações de trabalho sem perder o acesso e a ergonomia durante altas demandas de cocção.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/870-gas-145.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 700, 315",
        HobDimensions = "760x550",
        Voltage = "-",
        ElectricPower = "-",
        GasPower = "17",
        GasConsumption = "1,8 / 1,4",
        GrossWeight = "70",
        PackagingVolume = "0.3",
        Construction = "Aço Inox AISI 304 Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
},
new Product
{
    Id = 101,
    Name = "GV 870 EL TOP",
    ShortDescription = "Grelhador elétrico de bancada rebaixado - 2 zonas de cocção - Trifásico.",
    FullDescription = "Grelhador elétrico de bancada de 80 por 70 cm (versão rebaixada). A solução tecnológica Arris para padronizar produções robustas em ambientes que integram refrigeradores como base do equipamento.",
    ImageUrl = "https://www.arrisce.it/wp-content/uploads/2023/12/el-870-163.jpg",
    Category = "Grillvapor Compact",
    IsAvailable = true,
    TechnicalSpec = new TechnicalSpec
    {
        ProductDimensions = "800, 700, 315",
        HobDimensions = "760x530",
        Voltage = "400V 3N - 15A - 50/60Hz / 230V 3 - 26,1A - 50/60Hz",
        ElectricPower = "10.4",
        GasPower = "-",
        GasConsumption = "-",
        GrossWeight = "58",
        PackagingVolume = "0.35",
        Construction = "Aço Inox Scotch Brite",
        WaterConnection = "-",
        LoadingWater = "Manual",
        HeartProbe = "-"
    }
}
// --- FIM DA CATEGORIA GRILLVAPOR COMPACT ---



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