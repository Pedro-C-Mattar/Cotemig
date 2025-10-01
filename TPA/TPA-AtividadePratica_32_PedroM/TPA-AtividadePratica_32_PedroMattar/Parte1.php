<?php 
echo "<br>### QUESTÃO 01 <br>";
$NomeJogador = "Cristiano Ronaldo";
$MassaJogador = 87.0;
$AlturaJogador = 1.83;
$imc = $MassaJogador / ($AlturaJogador * $AlturaJogador);
echo "O IMC do Jogador " . $NomeJogador . "é igual a " . $imc;

echo "<br><br>### QUESTÃO 02 <br>";
if($imc >= 17 && $imc <= 18.49)
{
    echo "Abaixo do Peso";
}
else if ($imc >= 18.50 && $imc <= 24.99)
{
    echo "Peso Normal";
}
else if ($imc >= 25 && $imc <= 29.99)
{
    echo "Acima do Peso";
}

echo "<br><br> QUESTÃO 03 <br>";
echo "A quantidade de caracteres da variável NomeJogador é = " . strlen($NomeJogador);

echo "<br><br> QUESTÃO 04 <br>";
function CalcIMC($massa, $altura) {

    $IMC = $massa / ($altura * $altura);
    echo "<br> Uma pessoa com Massa = " . $massa . " e Altura = " . $altura . " tem o IMC = " . $IMC;
}
echo "Chamada da Função CalcIMC: ";
CalcIMC(80.0, 1.80);

echo "<br><br> QUESTÃO 05 <br>";
$Jogadoras = array("Bárbara", "Antonia", "Kathellen", "Rafaelle", "Luana", "Tamires", "Andressa Alves", "Ana Vitória", "Debinha", "Marta", "Adriana");
echo $Jogadoras[5];
echo "<br>";
echo $Jogadoras[9];

echo "<br><br> QUESTÃO 06 <br>";
class Atleta {
    public $atleta_nome;
    public $atleta_massa;
    public $atleta_altura;
    
    function set_nome($atleta_nome) {
    $this->atleta_nome = $atleta_nome;
    }
    function get_nome() {
    return $this->atleta_nome;
    }

    function set_massa($atleta_massa) {
    $this->atleta_massa = $atleta_massa;
    }
    function get_massa() {
    return $this->atleta_massa;
    }

    function set_altura($atleta_altura) {
    $this->atleta_altura = $atleta_altura;
    }
    function get_altura() {
    return $this->atleta_altura;
    }
    }
$JogadoraFutebol = new Atleta();
$JogadoraFutebol->set_nome('Marta');
$JogadoraFutebol->set_massa(65);
$JogadoraFutebol->set_altura(1.63);
echo "Nome Atleta: " . $JogadoraFutebol->get_nome();
echo "<br> Massa Atleta: " . $JogadoraFutebol->get_massa();
echo "<br> Altura Atleta: " . $JogadoraFutebol->get_altura();
?>