CREATE DATABASE MTS_Terry;

use MTS_Terry;

CREATE TABLE roles(
	id_rol INT PRIMARY KEY IDENTITY(1,1),
	nombre NVARCHAR(50) NOT NULL,
	descripcion NVARCHAR(100)
);

CREATE TABLE sucursales(
	id_sucursal INT PRIMARY KEY IDENTITY(1,1),
	ubicacion NVARCHAR(MAX) NOT NULL,
	telefono NVARCHAR(80)
);

CREATE TABLE bodegas(
	id_bodega INT PRIMARY KEY IDENTITY(1,1),
	nombre NVARCHAR(100) NOT NULL,
	id_sucursal INT FOREIGN KEY REFERENCES sucursales(id_sucursal)
);

CREATE TABLE localizacionesBodega(
	id_localizacionBodega INT PRIMARY KEY IDENTITY(1,1),
	descripcion NVARCHAR(100) NOT NULL,
	id_bodega INT FOREIGN KEY REFERENCES bodegas(id_bodega)
);

CREATE TABLE empleados (
	id_empleado INT PRIMARY KEY IDENTITY(1,1),
	nombre NVARCHAR(100) NOT NULL,
	apellido NVARCHAR(100) NOT NULL,
	salario MONEY NOT NULL CHECK(salario > 0),
	fecha_nacimiento DATETIME,
	cedula NVARCHAR(50) UNIQUE,
	fecha_ingreso DATETIME DEFAULT GETDATE(),
	estado BIT DEFAULT 1,
	celular NVARCHAR(50),
	direccion NVARCHAR(255),
	id_rol INT FOREIGN KEY REFERENCES roles(id_rol),
	id_sucursal INT FOREIGN KEY REFERENCES sucursales(id_sucursal)
);

CREATE TABLE usuarios (
	id_usuario INT PRIMARY KEY IDENTITY(1,1),
	nombre_usuario NVARCHAR(100) NOT NULL,
	contraseña NVARCHAR(200) NOT NULL,
	id_empleado INT FOREIGN KEY REFERENCES empleados(id_empleado) UNIQUE
)


CREATE TABLE categoriasProducto (
	id_categoriaProducto INT PRIMARY KEY IDENTITY(1,1),
	nombre NVARCHAR(40) NOT NULL,
	descripcion NVARCHAR(100)
);

CREATE TABLE productos (
	id_producto INT PRIMARY KEY IDENTITY(1,1),
	codigo NVARCHAR(100) NOT NULL,
	estado BIT DEFAULT 1,
	descripcion NVARCHAR(255) NOT NULL,
	nombre NVARCHAR(100) NOT NULL,
	precio_unitario DECIMAL(10,2),
	stock INT CHECK(stock > 0) NOT NULL,
	stock_minimo INT,
	id_categoriaProducto INT FOREIGN KEY REFERENCES categoriasProducto(id_categoriaProducto),
	id_localizacionBodega INT FOREIGN KEY REFERENCES localizacionesBodega(id_localizacionBodega)
);

CREATE TABLE compras (
	id_compra INT PRIMARY KEY IDENTITY(1,1),
	numero_compra INT,
	fecha DATETIME DEFAULT GETDATE(),
	id_tipo_pago INT FOREIGN KEY REFERENCES tiposPago(id_tipo_pago) NOT NULL
);

CREATE TABLE detalle_compras (
	id_detalle_compra INT PRIMARY KEY IDENTITY(1,1),
	id_compra INT FOREIGN KEY REFERENCES compras(id_compra) NOT NULL,
	id_proveedor INT FOREIGN KEY REFERENCES proveedores(id_proveedor) NOT NULL,
	id_producto INT FOREIGN KEY REFERENCES productos(id_producto) NOT NULL,
	cantidad INT,
	monto DECIMAL(8,2)
);

CREATE TABLE proveedores(
	id_proveedor INT PRIMARY KEY IDENTITY(1,1),
	nombre NVARCHAR(60) NOT NULL,
	telefono NVARCHAR(60) NOT NULL,
	direccion NVARCHAR(255)
);
CREATE TABLE tiposPago(
	id_tipo_pago INT PRIMARY KEY IDENTITY(1,1),
	tipo NVARCHAR(100) NOT NULL
);


CREATE TABLE categoriasServicio(
	id_categoriaServicio INT PRIMARY KEY IDENTITY(1,1),
	nombre NVARCHAR(100) NOT NULL,
	descripcion NVARCHAR(255)
);

CREATE TABLE servicios(
	id_servicio INT PRIMARY KEY IDENTITY(1,1),
	nombre NVARCHAR(100) NOT NULL,
	descripcion NVARCHAR(255),
	id_categoriaServicio INT FOREIGN KEY REFERENCES categoriasServicio(id_categoriaServicio)
);

CREATE TABLE clientes(
	id_cliente INT PRIMARY KEY IDENTITY(1,1),
	nombre NVARCHAR(100) NOT NULL,
	apellido NVARCHAR(100),
	direccion NVARCHAR(255)
);

CREATE TABLE gastos(
	id_gasto INT PRIMARY KEY IDENTITY(1,1),
	descripcion NVARCHAR(255) NOT NULL,
	monto DECIMAL(10,2) NOT NULL CHECK(monto != 0),
	id_sucursal INT FOREIGN KEY REFERENCES sucursales(id_sucursal) NOT NULL, 
	FechaGasto DATETIME not null default getdate()
);

ALTER TABLE gastos
ADD FechaGasto DATETIME NOT NULL DEFAULT GETDATE();




CREATE SEQUENCE numero_factura_sequence
AS INT
START WITH 3713        
INCREMENT BY 1;           

CREATE TABLE facturas(
	id_factura INT PRIMARY KEY IDENTITY(1,1),
	numero_factura INT DEFAULT NEXT VALUE FOR numero_factura_sequence,
	fecha DATETIME DEFAULT GETDATE(),
	id_empleado INT FOREIGN KEY REFERENCES empleados(id_empleado) NOT NULL,
	id_tipo_pago INT FOREIGN KEY REFERENCES tiposPago(id_tipo_pago) NOT NULL,
	id_cliente INT FOREIGN KEY REFERENCES clientes(id_cliente) NOT NULL
);

CREATE TABLE detalle_servicio(
	id_detalle_servicio INT PRIMARY KEY IDENTITY(1,1),
	id_empleado INT FOREIGN KEY REFERENCES empleados(id_empleado),
	id_servicio INT FOREIGN KEY REFERENCES servicios(id_servicio)
);

CREATE TABLE detalle_producto(
	id_detalle_producto INT PRIMARY KEY IDENTITY(1,1),
	id_producto INT FOREIGN KEY REFERENCES productos(id_producto),
	cantidad INT CHECK(cantidad > 0)
);

CREATE TABLE detalle_factura_producto (
	id_detalle_factura_producto INT PRIMARY KEY IDENTITY(1,1),
	id_detalle_producto INT FOREIGN KEY REFERENCES detalle_producto(id_detalle_producto),
	id_factura INT FOREIGN KEY REFERENCES facturas(id_factura),
	monto DECIMAL(10,2)
);

CREATE TABLE detalle_factura_servicio (
	id_detalle_factura_servicio INT PRIMARY KEY IDENTITY(1,1),
	id_detalle_servicio INT FOREIGN KEY REFERENCES detalle_servicio(id_detalle_servicio),
	id_factura INT FOREIGN KEY REFERENCES facturas(id_factura),
	monto DECIMAL(10,2)
);


select * from empleados;

