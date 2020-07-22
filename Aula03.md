Sobrecarga de Métodos (Overloading)
ex
public double Somar(double a, double b)
public double Somar(double a, double b, double c)

Sobrescrita de Métodos (Override)

public virtual void Imprimir()
public class B : A
public override void Imprimir()

virtual
É uma palavra reservada da
linguagem utilizada para permitir
que um método seja sobrescrito
por uma subclasse.
Para que haja sobrescrita de
método, a superclasse sempre
deverá declarar o método que seja
permitir sobrescrever como
"virtual"

App.config.xml 
Para que possamos acessar o arquivo App.config.xml de forma a ler os valores declarados, precisamos adicionar no projeto
 uma referência para a biblioteca: System.Configuration

Também ENVIA EMAIL
using System.Net.Mail; //importando..
using System.Configuration; //importando..

Também grava um arquivo XML

