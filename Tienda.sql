CREATE DATABASE Tienda;
USE Tienda;

CREATE TABLE productos(
id INT NOT NULL AUTO_INCREMENT,
nombre VARCHAR(20) NOT NULL,
descripcion VARCHAR(20) NOT NULL DEFAULT 'disponible',
precio FLOAT NOT NULL DEFAULT 0.0,
PRIMARY KEY(id));

INSERT INTO productos (nombre, descripcion, precio) VALUES ('Producto A','disponible',11), ('Producto B','disponible',8), ('Producto A','agotado',20);

DELIMITER $$
CREATE PROCEDURE obtenerProductosPorDescripcion(IN nombre_descripcion VARCHAR(255))
BEGIN
    SELECT * FROM productos
    WHERE descripcion = nombre_descripcion;
END$$
DELIMITER

CALL obtenerProductosPorDescripcion('disponible')

DELIMITER $$
CREATE PROCEDURE contarProductosPorDescripcion(
    IN nombre_descripcion VARCHAR(25),
    OUT numero INT)
BEGIN
    SELECT COUNT (id) 
    INTO numero
    FROM productos
    WHERE descripcion = nombre_descripcion;
END$$
DELIMITER

SELECT @numero AS disponibles;
SELECT @numero AS agotados;

DELIMITER $$
CREATE PROCEDURE venderProducto(
    INOUT beneficio INT(255),
    IN id_producto INT)
BEGIN
    SELECT @incremento_precio = precio 
    FROM productos
    WHERE id = id_producto;
    SET beneficio = beneficio + @incremento_precio;
END$$
DELIMITER

SET @beneficio = 0;
CALL venderProducto(@beneficio, 1);
CALL venderProducto(@beneficio, 2);
CALL venderProducto(@beneficio, 2);
SELECT @beneficio;

