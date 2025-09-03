-- Tabla: PuntoDeVenta
CREATE TABLE PuntoDeVenta (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100),
    descripcion NVARCHAR(255)
);

-- Tabla: FormaPago
CREATE TABLE FormaPago (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(100),
    descripcion NVARCHAR(255)
);

-- Tabla: VentaDiaria
CREATE TABLE VentaDiaria (
    id INT IDENTITY(1,1) PRIMARY KEY,
    fecha DATE,
    saldo DECIMAL(18,2),
    comentarios NVARCHAR(255)
);

-- Tabla: DetalleVentaDiaria
CREATE TABLE DetalleVentaDiaria (
    id INT IDENTITY(1,1) PRIMARY KEY,
    ventaDiariaId INT,
    formaPagoId INT,
    monto DECIMAL(18,2),
    comentarios NVARCHAR(255),
    FOREIGN KEY (ventaDiariaId) REFERENCES VentaDiaria(id),
    FOREIGN KEY (formaPagoId) REFERENCES FormaPago(id)
);

-- Tabla: TicketError
CREATE TABLE TicketError (
    id INT IDENTITY(1,1) PRIMARY KEY,
    ventaDiariaId INT,
    fecha DATE,
    monto DECIMAL(18,2),
    comentarios NVARCHAR(255),
    FOREIGN KEY (ventaDiariaId) REFERENCES VentaDiaria(id)
);

-- Tabla: Señia
CREATE TABLE Senia (
    id INT IDENTITY(1,1) PRIMARY KEY,
    ventaDiariaId INT,
    fecha DATE,
    monto DECIMAL(18,2),
    comentarios NVARCHAR(255),
    FOREIGN KEY (ventaDiariaId) REFERENCES VentaDiaria(id)
);

-- Tabla: CierreDeBalanza
CREATE TABLE CierreDeBalanza (
    id INT IDENTITY(1,1) PRIMARY KEY,
    ventaDiariaId INT,
    puntoVentaId INT,
    fecha DATE,
    cantidadTickets INT,
    totalVendido DECIMAL(18,2),
    comentarios NVARCHAR(255),
    FOREIGN KEY (ventaDiariaId) REFERENCES VentaDiaria(id),
    FOREIGN KEY (puntoVentaId) REFERENCES PuntoDeVenta(id),
);