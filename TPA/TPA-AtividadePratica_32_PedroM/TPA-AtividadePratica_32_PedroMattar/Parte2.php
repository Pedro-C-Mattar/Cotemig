<?php
echo "<br>### QUESTÃO 01 <br>";
$NomeEmpregado = "David Bombal";
$SalariaBruto = 20501.00;
$TotalDescontos = 5322.00;
$SalarioLiquido = $SalariaBruto - $TotalDescontos;
$RendaAnualLiquida = $SalarioLiquido * 12;
echo "O Empregado " . $NomeEmpregado . " terá uma renda líquida anual de R$ " . $RendaAnualLiquida;

echo "<br><br>### QUESTÃO 02 <br>";
echo "O Salário Líquido Mensal é = " . $SalarioLiquido;
if($SalarioLiquido >= 24240.01)
{
    echo "<br> Classe A";
}
else if ($SalarioLiquido >= 12120.01 && $SalarioLiquido <= 22240.00)
{
    echo "<br> Classe B";
}
else if ($SalarioLiquido >= 4848.01 && $SalarioLiquido <= 12120.00)
{
    echo "<br> Classe C";
}
else if ($SalarioLiquido >= 2424.01 && $SalarioLiquido <= 4848.00)
{
    echo "<br> Classe D";
}
else if ($SalarioLiquido <= 2424.00)
{
    echo "<br> Classe E";
}

echo "<br><br>### QUESTÃO 03 <br>";
echo "A quantidade de caracteres da variável NomeEmpregado é = " . strlen($NomeEmpregado);

echo "<br><br>### QUESTÃO 04 <br>";
function CalcRendaLiquidaAnual($salariobruto, $totaldescontos) {
    $salarioliquido = $salariobruto - $totaldescontos;
    $salarioliquidoanual = $salarioliquido * 12;
    echo "<br> Um empregado com Salário Bruto = " . $salariobruto . " e Desconto Mensal de " . $totaldescontos . " tem uma Renda Líquida Anual de " . $salarioliquidoanual;
}
echo "Chamada da Função CalcRendaLiquidaAnual: ";
CalcRendaLiquidaAnual(10500.00, 3124.00);

echo "<br><br>### QUESTÃO 05 <br>";
$Meses = array("Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro");
echo $Meses[2];
echo "<br>";
echo $Meses[7];

echo "<br><br>### QUESTÃO 06 <br>";
class Empregado {
    public $empregado_nome;
    public $empregado_salario;
    public $empregado_cargo;
    
    function set_nome($empregado_nome) {
    $this->empregado_nome = $empregado_nome;
    }
    function get_nome() {
    return $this->empregado_nome;
    }

    function set_salario($empregado_salario) {
    $this->empregado_salario = $empregado_salario;
    }
    function get_salario() {
    return $this->empregado_salario;
    }

    function set_cargo($empregado_cargo) {
    $this->empregado_cargo = $empregado_cargo;
    }
    function get_cargo() {
    return $this->empregado_cargo;
    }
    }
$Programador = new Empregado();
$Programador->set_nome('David Bombal');
$Programador->set_salario(30000.00);
$Programador->set_cargo('Gestor de Projetos');
echo "Nome do Empregado: " . $Programador->get_nome();
echo "<br> Salário do Empregado: " . $Programador->get_salario();
echo "<br> Cargo do Empregado: " . $Programador->get_cargo();
?>