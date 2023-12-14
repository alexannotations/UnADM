

-- Tabla para MariaDB

CREATE TABLE IF NOT EXISTS `huerto`
    (
    id SERIAL COMMENT 'identificador',
    precioUnitario INT UNSIGNED NOT NULL,
    productoNombre varchar(20) NOT NULL,
    descripcion varchar(150) NOT NULL,
    diponibilidad BOOLEAN NULL, /* indica si esta disponible para venta o no */
    updatets timestamp(0) NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Creación o actualización',
    PRIMARY KEY (id) USING BTREE
    ) ENGINE=InnoDB;


-- Registros para la base de datos

INSERT INTO huerto (precioUnitario,productoNombre,descripcion,diponibilidad,updatets) VALUES
	 (13,'Rosa','Rosa inividual varios colores',1,'2023-12-13 22:59:13'),
	 (10,'Caja','Caja para regalos',1,'2023-12-13 22:59:13'),
	 (120,'Ramo','Flores surtidas',1,'2023-12-13 22:59:13'),
	 (30,'Chocolate','Caja de chocolates',0,'2023-12-13 22:59:13'),
	 (13,'Gerbera','Flor',1,'2023-12-13 22:59:13');
