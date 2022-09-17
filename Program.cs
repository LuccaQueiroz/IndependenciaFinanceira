decimal gastosMensais, valorAInvestir;
double dividendYield;

Console.WriteLine("--- Vivendo de dividendos ---\n");

Console.Write("Gastos mensais (em R$)....: ");
gastosMensais = Convert.ToDecimal(Console.ReadLine());

Console.Write("Rendimentos mensais (%)...: ");
dividendYield = Convert.ToDouble(Console.ReadLine());

valorAInvestir = gastosMensais / Convert.ToDecimal(dividendYield / 100);

Console.WriteLine($"\nPara receber {gastosMensais:C} por mês com rendimentos de {dividendYield:N1}% você precisa ter investido {valorAInvestir:C}.");