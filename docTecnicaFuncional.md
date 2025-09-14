## Módulo Proveedores

El módulo de Proveedores gestiona de forma integral las operaciones de proveedores, productos, compras, ingresos y reportes. Está implementado en Blazor WebAssembly (.NET 9), con backend API y persistencia en base de datos relacional.

---

### Componentes Principales

1. **Gestión de Proveedores**
2. **Gestión de Productos**
3. **Gestión de Compras**
4. **Gestión de Ingresos**
5. **Reportes**

---

### 1. Gestión de Proveedores

Permite administrar los datos de los proveedores, incluyendo su alta, baja, modificación y consulta.

- **Alta de Proveedor:**  
  Formulario para registrar proveedor con campos: Nombre, Teléfono, CUIT, Dirección, Rubro (relación con tabla Rubro).  
  Validaciones: obligatorios, formato de CUIT, unicidad.

- **Baja de Proveedor:**  
  Eliminación lógica o física del registro.

- **Modificación de Proveedor:**  
  Edición de los datos existentes.

- **Consulta de Proveedores:**  
  Visualización en tabla, con filtros por nombre, rubro, CUIT.  
  Relación con compras realizadas.

---

### 2. Gestión de Productos

Permite administrar los productos que pueden ser adquiridos a proveedores.

- **Alta de Producto:**  
  Formulario con campos: Nombre, Rubro, Unidad de Medida, Proveedor, Precio de referencia.  
  Validaciones: obligatorios, unicidad por nombre y proveedor.

- **Baja de Producto:**  
  Eliminación lógica o física.

- **Modificación de Producto:**  
  Edición de datos.

- **Consulta de Productos:**  
  Tabla con filtros por rubro, proveedor, nombre.  
  Relación con compras y stock.

---

### 3. Gestión de Compras

Permite registrar y consultar compras a proveedores.

- **Alta de Compra:**  
  Formulario con:  
  - Proveedor (selección)
  - Fecha  
  - Comentarios  
  - Detalle de productos (producto, cantidad, precio unitario, subtotal)  
  - Cálculo automático de totales  
  - Registro de pagos asociados (monto, fecha, forma de pago)

- **Baja de Compra:**  
  Eliminación o anulación de la compra.

- **Modificación de Compra:**  
  Edición de datos y detalles.

- **Consulta de Compras:**  
  Tabla con filtros por proveedor, fecha, estado, tipo de pago.  
  Visualización de detalles y pagos.

---

### 4. Gestión de Ingresos

Permite registrar y consultar ingresos (ventas).

- **Alta de Ingreso:**  
  Formulario con:  
  - Fecha  
  - Detalle de productos vendidos  
  - Cliente (opcional)  
  - Total  
  - Forma de pago

- **Baja de Ingreso:**  
  Eliminación o anulación.

- **Modificación de Ingreso:**  
  Edición de datos.

- **Consulta de Ingresos:**  
  Tabla con filtros por fecha, tipo de pago.

---

### 5. Reportes

Reportes dinámicos y filtrables para análisis y control.

#### Reportes de Compras y Proveedores
- **Compras por Proveedor:**  
  Listado y totales de compras agrupadas por proveedor.
- **Compras por Producto:**  
  Detalle de compras de cada producto.
- **Compras por Fecha:**  
  Filtros por rango de fechas.
- **Compras por Estado:**  
  Estado: pagada, pendiente, anulada.
- **Compras por Tipo de Pago:**  
  Efectivo, transferencia, cheque, etc.

#### Reportes de Productos
- **Productos por Proveedor:**  
  Relación de productos ofrecidos por cada proveedor.
- **Productos por Categoría:**  
  Agrupamiento por rubro/categoría.

#### Reportes de Ingresos
- **Ingresos por Fecha:**  
  Ventas agrupadas por día, mes, año.
- **Ingresos por Tipo de Pago:**  
  Análisis de ingresos según forma de cobro.

---