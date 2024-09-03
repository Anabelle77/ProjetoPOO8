/*No código em java, tem a classe abstrata Poligono, que não pode ser
instanciada, mas 'Poligono[] p = new Poligono[10];' cria um array que
contem elementos do tipo Poligono, que podem ser instanciados indiretamente.

Código equivalente em C# ↓*/

public abstract class Poligono {
    public static void Main(string[] args) {
        Poligono[] p = new Poligono[10];
    }
}
