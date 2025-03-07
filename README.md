📖 Instruções para Usar o Programa "TextVision"
📌 Pré-requisitos

Antes de rodar o programa, certifique-se de que:

✅ Você tem o .NET Framework 4.8 instalado.

✅ O Tesseract OCR está configurado corretamente.

✅ Necessário instalar Tessdata.

✅ A pasta tessdata está no caminho correto (padrão: C:\tessdata).

🚀 Como Executar o Programa
1️⃣ Abra o CMD (Prompt de Comando)

Pressione Win + R, digite cmd e pressione Enter.
2️⃣ Navegue até a pasta do programa

Se o programa estiver, por exemplo, em C:\MeuLeitorDeTexto\bin\Debug, use:

cd C:\MeuLeitorDeTexto\bin\Debug

3️⃣ Execute o programa

Digite o seguinte comando e pressione Enter:

MeuLeitorDeTexto.exe Executar

🖥️ Como Usar o Programa

Após iniciar, o programa exibirá o seguinte menu:

======================== PROGRAMA LEITOR ==========================
Escolha 1 para TXT, 2 para PDF , 3 para IMG ou 0 para SAIR

1️⃣ Ler arquivos TXT

    Digite 1, pressione Enter e informe o caminho do arquivo .txt.

2️⃣ Ler arquivos PDF

    Digite 2, pressione Enter e informe o caminho do arquivo .pdf.

3️⃣ Ler texto de uma imagem (OCR - Tesseract)

    Digite 3, pressione Enter e informe o caminho do arquivo de imagem.

0️⃣ Sair do programa

    Digite 0 e pressione Enter para encerrar o programa.

🛠 Possíveis Erros e Soluções

🔴 Erro: "Arquivo não encontrado"
✅ Certifique-se de que digitou o caminho do arquivo corretamente.

🔴 Erro: "Erro ao ler PDF"
✅ O arquivo pode estar corrompido ou protegido.

🔴 Erro: "Tesseract não encontrado"
✅ Verifique se o caminho da pasta tessdata está correto no código.
