<?php

echo "<h4>Esta página é dinâmica; executada no servidor Web e enviada ao navegador!</h4>";
echo "<h3>Aprendemos a linguagem de programação de PHP</h3>";

$nota1 = 10;
$nota2 = 9;
$media = ($nota1 + $nota2) / 2;
echo "A média das notas é igual a $media";

echo "<br>" . date('D/M/Y');
$nome = "Pedro";
echo "<br>" . strtoupper($nome);
echo "<br>Pedro tem " . strlen($nome) . " letras<br>";
echo "O número Sorteado foi: " . (rand(10, 100));

if ($media >= 7){
    echo "<br>A média é igual a: " . $media . "<br> Ou seja, aluno: Aprovado";
}
else{
    echo "<br>A média é igual a: " . $media . "<br> Ou seja, aluno: Reprovado";
}

$disciplinas = array("BD", "TPA", "POO", "MATEMÁTICA", "RAC");
echo "<hr><h4>Mostrando o conteúdo do array indexado</h4>";
var_dump($disciplinas);
echo "A disciplina com o índice 1, ou seja, a segunda do array é: " . $disciplinas[1];

$tam_array = count($disciplinas);
for($x = 0; $x < $tam_array; $x ++){
    echo "<br>" . $disciplinas[$x];
}

echo "<h4>Usando FOREACH</h4>";
foreach($disciplinas as $x){
    echo "$x <br>";
}

$professor_disciplina = array("Bernardo" => "BD", "Halley" => "TPA", "Sandra" => "POO", "Bruno" => "MATEMÁTICA", "Artur" => "RAC");
echo "<hr><h3>Mostrando o conteúdo do array associativo</h3>";
var_dump($professor_disciplina);
foreach($professor_disciplina as $key => $value){
    echo "<br>- Professor(a) " . $key . " ministra a disciplina de " . $value;
}

?>