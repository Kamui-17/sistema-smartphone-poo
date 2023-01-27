# Programa Smartphone POO.

Realização do projeto proposto no Bootcamp da Pottencial .NET Developer.

No desafio foi solicitado a construção de um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. O objetivo é que se faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos. Também foi requisitado algumas regras e validações, sendo essas:

* A classe Smartphone deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
* A classe Nokia e Iphone devem ser classes filhas de Smartphone.
* O método InstalarAplicativo deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.