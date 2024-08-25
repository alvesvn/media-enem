// Programa para calcular a média da prova do enem

//Funções

static void MediaEnem(){
    
    Console.Clear(); 

    Console.WriteLine("Bem-vindo ao Média Enem - calcule sua média de forma rápida e prática!");

    Console.WriteLine("");

    Console.WriteLine("Tenham suas notas em mãos e informe conforme as áreas de conhecimento do ENEM, exemplo:");

    Console.WriteLine("");

    Console.WriteLine("1. Linguagens, Códigos e suas Tecnologias: nota de 0 a 1000");
    Console.WriteLine("2. Ciências Humanas e suas Tecnologias: nota de 0 a 1000");
    Console.WriteLine("3. Ciências da Natureza e suas Tecnologias: nota de 0 a 1000");
    Console.WriteLine("4. Matemática e suas Tecnologias: nota de 0 a 1000");
    Console.WriteLine("5. Redação: nota de 0 a 1000");

    Console.WriteLine("");

    Console.WriteLine("Informe a nota de Linguagens, códigos e suas Tecnologias:");
    float NotaLing = float.Parse(Console.ReadLine());
            if (NotaLing < 0 || NotaLing > 1000){
            Console.WriteLine("Erro: informe a nota corretamente entre 0 e 1000.");
            Console.ReadKey(); 
            MediaEnem();
        }

    Console.WriteLine("");

    Console.WriteLine("Informe a nota de Ciências Humanas e suas tecnologias:");
    float NotaHum = float.Parse(Console.ReadLine());
            if (NotaHum < 0 || NotaHum > 1000){
            Console.WriteLine("Erro: informe a nota corretamente entre 0 e 1000.");
            Console.ReadKey(); 
            MediaEnem();
        }

    Console.WriteLine("");

    Console.WriteLine("Informe a nota de Ciências da Natureza e suas tecnologias:");
    float NotaNat = float.Parse(Console.ReadLine());
            if (NotaNat < 0 || NotaNat > 1000){
            Console.WriteLine("Erro: informe a nota corretamente entre 0 e 1000.");
            Console.ReadKey(); 
            MediaEnem();
        }

    Console.WriteLine("");

    Console.WriteLine("Informe a nota de Matemática e suas tecnologias:");
    float NotaBio = float.Parse(Console.ReadLine());
            if (NotaBio < 0 || NotaBio > 1000){
            Console.WriteLine("Erro: informe a nota corretamente entre 0 e 1000.");
            Console.ReadKey(); 
            MediaEnem();
        }

    Console.WriteLine("");
    
    Console.WriteLine("Informe a nota de redação");
    float NotaRed = float.Parse(Console.ReadLine());
            if (NotaRed < 0 || NotaRed > 1000){
            Console.WriteLine("Erro: informe a nota corretamente entre 0 e 1000.");
            Console.ReadKey(); 
            MediaEnem();
        }
    
    //Imprimindo o resultado

    float Total = NotaLing + NotaHum + NotaNat + NotaBio + NotaRed;

    float Media = Total / 5;

    Console.WriteLine("");
    
    Console.WriteLine($"A sua média do enem é: {Media} pontos.");
    
     Console.WriteLine("");

    Console.WriteLine("Deseja calcular novamente?");
    Console.WriteLine("1 - Sim");
    Console.WriteLine("2 - Não");
    short Nav = short.Parse(Console.ReadLine());

    switch (Nav){
        case 1: MediaEnem(); break; 
        case 2: Exit(); break;
        default: MediaEnem(); break;
    }

    Console.ReadKey();

}

static void Exit(){
    Console.Clear(); 

    Console.WriteLine("Obrigado, até a próxima!");
}

MediaEnem();


