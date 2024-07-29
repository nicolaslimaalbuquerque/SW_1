<?php

    $nome = "ANDERSON";

    if($nome == 'ANDERSON'|| $nome=='anderson'){
        echo "BEM VINDO";
    }
    else{
        echo " USUARIO NÃO ENCONTRADO";
    }

    echo"<hr>";

    for($x=1;$x<=10;$x++){
        if($x % 2 == 0){
            echo $x . "<br>";
        }else{
            echo"IMPAR <br>";
        }
    }
    echo "<hr>";

    $a= 1;
    while($a<=10){
        echo $a . "<br>";
        $a = $a +1;
    }




?>