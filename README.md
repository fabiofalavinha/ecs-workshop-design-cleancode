# ecs-workshop-design-cleancode

Definição de Conceitos
======================

Banco (classe)
	- Abrir conta
Contas (abstração)
	- Número de 6 Dígitos, começando por 1 => (struct ou classe)
	- Pode possuir 1 ou mais Clientes => Array de Clientes
	- Imprimir Extrato da Conta => método ou função
	- Conta Corrente (classe)
		- Taxa Administrativa: 0.05% => (struct ou classe) ou double
	- Conta Especial (classe)
		- Taxa Administrativa: 0% => (struct ou classe) ou double
		- Para abrir esta conta precisa de R$ 10.000,00 
			=> (struct ou classe) ou double 
Agência => (classe)
Cliente (asbtração)
	- Pessoa Física (classe)
	- Pessoa Jurídica (classe)
Operação (classe)
	- Ao efetuar uma operação aplicar a Taxa Administrativa da Conta
	- Pagar Boleto (Boleto => Conta => Pessoa Juridica)
	- Transferência
		- Débito
		- Crédito
		
TransaçãoFinanceira	
Recibo / Comprovante
		
			Operação (abstração)
Transferência       PagarBoleto      Depositar
		
		
Operacao operacao = new Transferencia(contaA, contaB, valorMonetario);
Comprovante comprovante = operacao.Executar();
comprovante.Imprimir();

public TransacaoFinanceira Debitar(ValorMonetario)
{
	// validacoes
	// aplicar taxa administrativa
}

public Comprovante Executar()
{
	TransacaoFinanceira transacaoResultadoContaADebito = contaA.Debitar(valorMonetario);
	TransacaoFinanceira transacaoResultadoContaBDebito = contaB.Creditar(valorMonetario);
	return new Comprovante(transacaoResultadoContaADebito, transacaoResultadoContaBDebito);
}
