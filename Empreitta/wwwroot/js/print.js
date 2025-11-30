window.imprimirArea = (elementId) => {

    const conteudo = document.getElementById(elementId).innerHTML;

    const janela = window.open('', '_blank');

    janela.document.write(`
        <html>
            <head>
                <title>Impressão</title>
                <style>
                    body { font-family: Arial, sans-serif; margin: 20px; }
                    table { width: 100%; border-collapse: collapse; }
                    th, td { padding: 8px; border: 1px solid #ccc; }
                    h3, h4, h5 { margin: 0 0 15px; }
                </style>
            </head>
            <body>
                ${conteudo}
            </body>
        </html>
    `);

    janela.document.close();
    janela.focus();

    setTimeout(() => {
        janela.print();
        janela.close();
    }, 300);

};
