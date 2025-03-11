// 3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
// • O menor valor de faturamento ocorrido em um dia do mês;
// • O maior valor de faturamento ocorrido em um dia do mês;
// • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

// IMPORTANTE:
// a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
// b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;


const fs = require('fs');
const path = require('path');

const caminho = path.join(__dirname, 'dados.json');

function carregarFaturamento(caminho) {
    try {
        const data = fs.readFileSync(caminho, 'utf-8');
        return JSON.parse(data);
    } catch (error) {
        console.error('Erro ao ler o JSON:', error);
        return [];
    }
}

const faturamento = carregarFaturamento(caminho);

function calcularFaturamento(faturamento) {
    let valoresValidos = faturamento
        .filter(dia => dia.valor > 0)
        .map(dia => dia.valor);

    const menorValor = Math.min(...valoresValidos);
    const maiorValor = Math.max(...valoresValidos);
    const mediaMensal = valoresValidos.reduce((acc, val) => acc + val, 0) / valoresValidos.length;
    const diasAcimaDaMedia = valoresValidos.filter(valor => valor > mediaMensal).length;

    return {
        menorValor,
        maiorValor,
        diasAcimaDaMedia
    };
}

let resultado = calcularFaturamento(faturamento);
console.log("Menor valor de faturamento:", resultado.menorValor);
console.log("Maior valor de faturamento:", resultado.maiorValor);
console.log("Dias com faturamento acima da média:", resultado.diasAcimaDaMedia);