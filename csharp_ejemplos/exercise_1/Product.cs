/* Ejercicio 1
    Crea Product con: Id (solo lectura), Name (valida no vacío), Price (>= 0), Stock (>= 0).
    Agrega dos constructores: uno completo y otro con precio 0 por defecto.
    Crea 2 instancias en Main y muéstralas por consola.
    Criterio pedagógico: observa si validan datos en propiedades (no en la UI), y si los mensajes de error son claros.
 */

//! --- SOLUCIÓN AL EJERCICIO ---

//* Representa un producto con validaciones en sus propiedades.

namespace exercise_1
{
    public class Product
    {
        //? Campo privado para almacenar el nombre del producto.
        private string _name;

        //* Identificador único del producto (solo lectura).

        public int Id { get; }

        //* Nombre del producto. Valida que no sea nulo ni vacío.

        public string Name
        {
            get => _name;
            set
            {
                //? Validación para asegurar que el nombre no sea nulo ni solo espacios.
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nombre requerido");
                _name = value.Trim();
            }
        }

        //* Precio del producto. Debe ser mayor o igual a 0.

        public decimal Price { get; set; }

        //* Stock disponible del producto. Debe ser mayor o igual a 0.

        public int Stock { get; set; }

        //* Constructor completo que inicializa todas las propiedades.

        //* <param name="id">Identificador único (mayor a 0).</param>
        //* <param name="name">Nombre del producto (no vacío).</param>
        //* <param name="price">Precio (>= 0).</param>
        //* <param name="stock">Stock (>= 0).</param>
        public Product(int id, string name, decimal price, int stock)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id));
            Id = id;
            Name = name;
            if (price < 0)
                throw new ArgumentException("El precio no puede ser negativo");
            Price = price;
            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo");
            Stock = stock;
        }

        //* Constructor alternativo que inicializa el precio en 0 por defecto.

        //* <param name="id">Identificador único.</param>
        //* <param name="name">Nombre del producto.</param>
        //* <param name="stock">Stock disponible.</param>
        public Product(int id, string name, int stock)
            : this(id, name, 0, stock)
        {
            //? Utiliza el constructor principal, asignando precio 0.
        }

        //* Representación en texto del producto.

        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Name}, Precio: {Price:C}, Stock: {Stock}";
        }
    }
}
