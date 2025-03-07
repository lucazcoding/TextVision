using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using Tesseract;

namespace MeuLeitorDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "Executar")
            {
            ProgramPrincipal:
                Console.Clear();
                Console.WriteLine("======================== PROGRAMA LEITOR ==========================");
                Console.WriteLine("Escolha 1 para TXT, 2 para PDF , 3 para IMG ou 0 para SAIR");
                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                    ArquivoTXT:
                        string linha;
                        Console.Clear();
                        try
                        {
                            Console.WriteLine("Digite o caminho para o arquivo txt:");
                            args[0] = Console.ReadLine();
                            StreamReader scanner = new StreamReader(args[0]);
                            linha = scanner.ReadLine();

                            Console.Clear();
                            while (linha != null)
                            {
                                Console.WriteLine(linha);
                                linha = scanner.ReadLine();
                            }

                            scanner.Close();
                            Console.WriteLine();
                        }
                        catch (Exception erro)
                        {
                            Console.Clear();
                            Console.WriteLine("Não foi possível ler o arquivo verifique se digitou corretamente ou se o arquivo não está corrompido\n ", erro);
                        }

                        Console.WriteLine("Deseja adicionar um novo arquivo TXT \" s \" ou \" n \"   ");
                        char decisao1 = Convert.ToChar(Console.ReadLine());
                        switch (decisao1)
                        {
                            default:
                                break;
                            case 's':
                                goto ArquivoTXT;
                            case 'n':
                                goto ProgramPrincipal;
                        }
                        break;

                    case 2:
                    ArquivoPDF:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Digite o caminho para o PDF: ");
                            args[0] = Console.ReadLine();
                            using (PdfReader leitor = new PdfReader(args[0]))
                            using (PdfDocument pdf = new PdfDocument(leitor))
                            {
                                for (int i = 1; i <= pdf.GetNumberOfPages(); i++)
                                {
                                    string textoPagina = PdfTextExtractor.GetTextFromPage(pdf.GetPage(i));
                                    Console.WriteLine(textoPagina);
                                }
                            }
                        }
                        catch (Exception erro)
                        {
                            Console.Clear();
                            Console.WriteLine("Erro ao ler PDF: " + erro);
                        }
                        Console.WriteLine("Deseja adicionar um novo arquivo PDF \" s \" ou \" n \"   ");
                        char decisao2 = Convert.ToChar(Console.ReadLine());
                        switch (decisao2)
                        {
                            default:
                                break;
                            case 's':
                                goto ArquivoPDF;
                            case 'n':
                                goto ProgramPrincipal;
                        }
                        break;

                    case 3:
                    ArquivoIMG:
                        try
                        {
                            string tessDataPath = @"C:\tessdata"; // Altere para o caminho da sua pasta tessdata
                            Console.Clear();
                            Console.WriteLine("Digite o caminho para a IMAGEM juntamente a extensão do arquivo.: ");
                            args[0] = Console.ReadLine();

                            Console.Clear();
                            // Criação de um objeto de reconhecimento de OCR
                            using (var engine = new TesseractEngine(tessDataPath, "eng", EngineMode.Default))
                            {
                                // Carrega a imagem
                                using (var img = Pix.LoadFromFile(args[0]))
                                {
                                    // Extrai o texto da imagem
                                    var result = engine.Process(img);
                                    string extractedText = result.GetText();

                                    // Exibe o texto extraído
                                    Console.WriteLine("Texto extraído da imagem:\n");
                                    Console.WriteLine(extractedText);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();
                            Console.WriteLine("Error IMG: ", ex);
                        }
                        Console.WriteLine("Deseja adicionar uma nova IMAGEM \" s \" ou \" n \"   ");
                        char decisao3 = Convert.ToChar(Console.ReadLine());
                        switch (decisao3)
                        {
                            default:
                                break;
                            case 's':
                                goto ArquivoIMG;
                            case 'n':
                                goto ProgramPrincipal;
                        }
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Programa Encerrado");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        goto ProgramPrincipal;
                }
            }
        }
    }
}
