-- Tabla: Rubro
CREATE TABLE Rubro (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) ,
    descripcion NVARCHAR(255)
);

-- Tabla: UnidadMedida
CREATE TABLE UnidadMedida (
    id INT IDENTITY(1,1) PRIMARY KEY,
    descripcion NVARCHAR(100) 
);

-- Tabla: FormaPago
CREATE TABLE FormaPago (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) ,
    descripcion NVARCHAR(255)
);

---- Tabla: Estado (Enum)
--CREATE TABLE Estado (
--    id INT IDENTITY(1,1) PRIMARY KEY,
--    descripcion NVARCHAR(100) 
--);

-- Tabla: Proveedor
CREATE TABLE Proveedor (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) ,
    telefono NVARCHAR(50),
    direccion NVARCHAR(255),
    CUIT NVARCHAR(20),
    rubroId INT,
    FOREIGN KEY (rubroId) REFERENCES Rubro(id)
);

-- Tabla: Producto
CREATE TABLE Producto (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) ,
    descripcion NVARCHAR(255),
    unidadMedidaId INT,
    rubroId INT,
    FOREIGN KEY (unidadMedidaId) REFERENCES UnidadMedida(id),
    FOREIGN KEY (rubroId) REFERENCES Rubro(id)
);

-- Tabla: Compra
CREATE TABLE Compra (
    id INT IDENTITY(1,1) PRIMARY KEY,
    proveedorId INT ,
    fecha DATE ,
    estado INT,
    total DECIMAL(18,2),
    comentarios NVARCHAR(255),
    FOREIGN KEY (proveedorId) REFERENCES Proveedores(id)
    --FOREIGN KEY (estado) REFERENCES Estado(id)
);

-- Tabla: DetalleDeCompra
CREATE TABLE DetalleDeCompra (
    id INT IDENTITY(1,1) PRIMARY KEY,
    compraId INT ,
    productoId INT ,
    precioUnitario DECIMAL(18,2) ,
    cantidad DECIMAL(18,2) ,
    subtotal DECIMAL(18,2) ,
    FOREIGN KEY (compraId) REFERENCES Compra(id),
    FOREIGN KEY (productoId) REFERENCES Producto(id)
);

-- Tabla: PagoCompra
CREATE TABLE PagoCompra (
    id INT IDENTITY(1,1) PRIMARY KEY,
    compraId INT ,
    fecha DATE ,
    formaPagoId INT ,
    monto DECIMAL(18,2) ,
    comentarios NVARCHAR(255),
    FOREIGN KEY (compraId) REFERENCES Compra(id),
    FOREIGN KEY (formaPagoId) REFERENCES FormaPago(id)
);

-- Tabla: Gasto
CREATE TABLE Gasto (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100) ,
    descripcion NVARCHAR(255),
    formaPagoId INT,
    monto DECIMAL(18,2),
    rubroId INT,
    FOREIGN KEY (formaPagoId) REFERENCES FormaPago(id),
    FOREIGN KEY (rubroId) REFERENCES Rubro(id)
);