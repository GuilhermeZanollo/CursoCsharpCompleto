namespace Projeto45.Entities
{
    internal class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}

/*
 1. A propriedade tem um comportamento ou lógica própria?
Se a propriedade Vehicle tem comportamentos ou regras de negócio próprios (por exemplo, calcular um preço de aluguel com base no tipo de 
veículo ou verificar a disponibilidade do veículo), isso indica que ela pode precisar de uma classe separada. Vehicle pode precisar encapsular 
mais detalhes ou ações que justificam uma classe separada.

2. A propriedade pode ter múltiplas variações?
Se um Vehicle pode ter várias variações (como diferentes tipos de veículos, diferentes características ou atributos como modelo, marca, ano de 
fabricação, etc.), talvez seja necessário uma classe para encapsular essas variações. Por exemplo, se um "Carro" tem atributos diferentes de 
uma "Moto", uma classe separada ajudaria a organizar essas variações.

3. A propriedade tem relacionamentos com outras entidades?
Se Vehicle tem relacionamentos significativos com outras entidades, como Owner ou RentalHistory, pode ser um indicativo de que Vehicle precisa 
ser uma classe independente, pois ela estará envolvida em mais interações.

4. A propriedade pode ser reutilizada em outras partes do sistema?
Se você antecipa que a entidade Vehicle será reutilizada em outros contextos, seja em outros métodos, serviços ou componentes, criar uma classe 
separada seria uma boa prática. Isso melhora a reutilização e organização do código, evitando duplicação de lógica e melhorando a manutenção.

5. Quais informações a propriedade Vehicle deve armazenar?
Se a propriedade Vehicle precisar armazenar informações como Make, Model, Year, VIN, Mileage, entre outras características, ela pode justificar
uma classe. Isso organiza melhor essas propriedades em um único objeto coeso, com maior clareza de onde e como os dados são manipulados.

6. É uma entidade ou apenas um valor simples?
Se Vehicle representar algo complexo e com uma identidade própria (com o seu próprio conjunto de dados e responsabilidades), então ela deve ser 
uma classe. Caso contrário, se for apenas um valor simples ou algo que pode ser representado por um tipo primitivo, você pode não precisar de 
uma classe.
Exemplos de cenários que indicam a necessidade de uma classe separada:
Cenário 1: Se você tem um sistema de aluguel de carros, e cada Vehicle tem atributos como Model, LicensePlate, RentalHistory, e CurrentStatus 
(disponível, alugado, em manutenção), esses são comportamentos e dados específicos de um Vehicle, e faz sentido que Vehicle seja sua própria 
classe.

Cenário 2: Se você tem uma aplicação onde há diferentes tipos de veículos, como Car, Motorcycle, Truck, e cada tipo tem atributos e 
comportamentos diferentes, isso indica que cada tipo de veículo pode se beneficiar de ser uma classe separada (e talvez uma hierarquia de classes, 
com Vehicle como classe base).
 */