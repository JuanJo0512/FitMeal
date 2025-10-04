--Insertar en tabla alimentos--

-- Categoría: Cereal
INSERT INTO ALIMENTO (Nombre, Categoria, Calorias, Proteinas, Carbohidratos, Grasas) VALUES
('Quinoa cocida', 'Cereal', 120.00, 4.10, 21.30, 1.90), -- Libre de gluten, Vegano, Vegetariano
('Arroz integral', 'Cereal', 111.00, 2.60, 23.00, 0.90), -- Libre de gluten, Vegano, Vegetariano
('Avena en hojuelas', 'Cereal', 389.00, 16.90, 66.30, 6.90), -- Vegetariano
('Pan integral', 'Cereal', 247.00, 13.00, 49.70, 3.80), -- Vegetariano
('Tortilla de maíz', 'Cereal', 218.00, 5.60, 44.70, 2.80), -- Libre de gluten, Vegano, Vegetariano
('Couscous', 'Cereal', 376.00, 12.80, 77.40, 0.60), -- Vegetariano
('Trigo sarraceno', 'Cereal', 343.00, 13.30, 71.50, 3.40), -- Libre de gluten, Vegano, Vegetariano

-- Categoría: Fruta
('Plátano', 'Fruta', 89.00, 1.10, 22.80, 0.30), -- Libre de gluten, Vegano, Vegetariano
('Frutos rojos', 'Fruta', 40.00, 1.00, 9.00, 0.50), -- Libre de gluten, Vegano, Vegetariano, Bajo en carbohidratos
('Manzana', 'Fruta', 52.00, 0.30, 13.80, 0.20), -- Libre de gluten, Vegano, Vegetariano
('Aguacate', 'Fruta', 160.00, 2.00, 8.50, 14.70), -- Libre de gluten, Vegano, Vegetariano, Bajo en carbohidratos
('Fresa', 'Fruta', 32.00, 0.70, 7.70, 0.30), -- Libre de gluten, Vegano, Vegetariano, Bajo en carbohidratos
('Mango', 'Fruta', 60.00, 0.80, 15.00, 0.40), -- Libre de gluten, Vegano, Vegetariano
('Naranja', 'Fruta', 47.00, 0.90, 11.80, 0.10), -- Libre de gluten, Vegano, Vegetariano

-- Categoría: Legumbre
('Garbanzos cocidos', 'Legumbre', 164.00, 8.90, 27.40, 2.60), -- Libre de gluten, Vegano, Vegetariano
('Lentejas cocidas', 'Legumbre', 116.00, 9.00, 20.10, 0.40), -- Libre de gluten, Vegano, Vegetariano
('Edamame', 'Legumbre', 122.00, 11.00, 9.00, 5.00), -- Libre de gluten, Vegano, Vegetariano, Alto en proteína
('Alubias blancas', 'Legumbre', 333.00, 23.00, 60.00, 1.50), -- Libre de gluten, Vegano, Vegetariano, Alto en proteína
('Frijoles negros', 'Legumbre', 341.00, 21.60, 62.40, 1.50), -- Libre de gluten, Vegano, Vegetariano, Alto en proteína
('Hummus', 'Legumbre', 166.00, 7.90, 19.30, 9.60), -- Libre de gluten, Vegano, Vegetariano

-- Categoría: Vegetal
('Espinacas', 'Vegetal', 23.00, 2.90, 3.60, 0.40), -- Libre de gluten, Vegano, Vegetariano, Bajo en carbohidratos
('Brócoli', 'Vegetal', 34.00, 2.80, 6.60, 0.40), -- Libre de gluten, Vegano, Vegetariano, Bajo en carbohidratos
('Batata (camote)', 'Vegetal', 86.00, 1.60, 20.10, 0.10), -- Libre de gluten, Vegano, Vegetariano
('Pimientos', 'Vegetal', 20.00, 0.90, 4.60, 0.30), -- Libre de gluten, Vegano, Vegetariano, Bajo en carbohidratos
('Lechuga', 'Vegetal', 15.00, 1.40, 2.90, 0.20), -- Libre de gluten, Vegano, Vegetariano, Bajo en carbohidratos
('Tomate', 'Vegetal', 18.00, 0.90, 3.90, 0.20), -- Libre de gluten, Vegano, Vegetariano, Bajo en carbohidratos
('Zanahoria', 'Vegetal', 41.00, 0.90, 9.60, 0.20), -- Libre de gluten, Vegano, Vegetariano

-- Categoría: Carne
('Pechuga de pollo', 'Carne', 165.00, 31.00, 0.00, 3.60), -- Libre de gluten, Alto en proteína, Bajo en carbohidratos
('Carne molida magra', 'Carne', 250.00, 26.00, 0.00, 17.00), -- Libre de gluten, Alto en proteína, Bajo en carbohidratos
('Jamón de pavo', 'Carne', 120.00, 20.00, 2.00, 3.00), -- Alto en proteína, Bajo en carbohidratos
('Filete de ternera', 'Carne', 270.00, 26.00, 0.00, 18.00), -- Libre de gluten, Alto en proteína, Bajo en carbohidratos
('Pollo deshebrado', 'Carne', 165.00, 31.00, 0.00, 3.60), -- Libre de gluten, Alto en proteína, Bajo en carbohidratos

-- Categoría: Pescado
('Salmón', 'Pescado', 208.00, 20.00, 0.00, 13.00), -- Libre de gluten, Alto en proteína, Bajo en carbohidratos
('Atún en agua', 'Pescado', 116.00, 25.00, 0.00, 1.00), -- Libre de gluten, Alto en proteína, Bajo en carbohidratos
('Tilapia', 'Pescado', 96.00, 20.00, 0.00, 1.70), -- Libre de gluten, Alto en proteína, Bajo en carbohidratos
('Bacalao', 'Pescado', 82.00, 18.00, 0.00, 0.70), -- Libre de gluten, Alto en proteína, Bajo en carbohidratos
('Merluza', 'Pescado', 86.00, 18.00, 0.00, 1.00), -- Libre de gluten, Alto en proteína, Bajo en carbohidratos

-- Categoría: Proteína-Animal
('Huevo entero', 'Proteína', 155.00, 13.00, 1.10, 11.00), -- Libre de gluten, Alto en proteína, Vegetariano
('Claras de huevo', 'Proteína', 52.00, 11.00, 0.70, 0.00), -- Libre de gluten, Alto en proteína, Vegetariano, Bajo en carbohidratos
('Yogur griego', 'Proteína', 59.00, 10.00, 3.60, 0.40), -- Libre de gluten, Vegetariano
('Leche de vaca', 'Proteína', 42.00, 3.40, 5.00, 1.00), -- Libre de gluten, Vegetariano
('Queso cottage', 'Proteína', 98.00, 11.00, 3.40, 4.30), -- Libre de gluten, Vegetariano
('Requesón', 'Proteína', 98.00, 11.00, 3.40, 4.30), -- Libre de gluten, Vegetariano

-- Categoría: Proteína-Vegetal
('Tofu firme', 'Proteína-Vegetal', 144.00, 17.30, 4.30, 8.70), -- Libre de gluten, Vegano, Vegetariano, Alto en proteína, Bajo en carbohidratos
('Seitan', 'Proteína-Vegetal', 370.00, 75.00, 14.00, 4.00), -- Vegano, Vegetariano
('Tempeh', 'Proteína-Vegetal', 193.00, 19.00, 9.40, 10.80), -- Libre de gluten, Vegano, Vegetariano
('Lentejas rojas', 'Proteína-Vegetal', 358.00, 24.60, 63.40, 1.50), -- Libre de gluten, Vegano, Vegetariano
('Frijoles de soya', 'Proteína-Vegetal', 446.00, 36.50, 30.20, 19.90), -- Libre de gluten, Vegano, Vegetariano
('Quinoa', 'Proteína-Vegetal', 120.00, 4.10, 21.30, 1.90), -- Libre de gluten, Vegano, Vegetariano

-- Categoría: Lácteo-Vegetal
('Leche de coco', 'Lácteo-Vegetal', 230.00, 2.30, 5.50, 23.80), -- Libre de gluten, Intolerante a la lactosa, Vegano, Vegetariano
('Leche de avena', 'Lácteo-Vegetal', 47.00, 1.00, 6.80, 2.00), -- Intolerante a la lactosa, Vegano, Vegetariano
('Leche de almendras', 'Lácteo-Vegetal', 15.00, 0.60, 0.60, 1.20), -- Libre de gluten, Intolerante a la lactosa, Vegano, Vegetariano
('Leche de soja', 'Lácteo-Vegetal', 54.00, 3.30, 5.60, 1.80), -- Libre de gluten, Intolerante a la lactosa, Vegano, Vegetariano
('Yogur de soja', 'Lácteo-Vegetal', 61.00, 4.10, 7.60, 2.10), -- Libre de gluten, Intolerante a la lactosa, Vegano, Vegetariano

-- Categoría: Semilla
('Semillas de chía', 'Semilla', 486.00, 16.50, 42.10, 30.70), -- Libre de gluten, Vegano, Vegetariano, Alto en proteína
('Semillas de lino', 'Semilla', 534.00, 18.30, 28.90, 42.20), -- Libre de gluten, Vegano, Vegetariano
('Semillas de calabaza', 'Semilla', 559.00, 30.20, 10.70, 49.00), -- Libre de gluten, Vegano, Vegetariano, Alto en proteína
('Semillas de sésamo', 'Semilla', 573.00, 17.70, 23.50, 49.70), -- Libre de gluten, Vegano, Vegetariano
('Semillas de girasol', 'Semilla', 584.00, 20.70, 20.00, 51.50), -- Libre de gluten, Vegano, Vegetariano, Alto en proteína
('Semillas de cáñamo', 'Semilla', 553.00, 31.60, 8.70, 48.80), -- Libre de gluten, Vegano, Vegetariano, Alto en proteína

-- Categoría: Suplemento
('Proteína en polvo', 'Suplemento', 370.00, 80.00, 5.00, 5.00), -- Libre de gluten, Alto en proteína
('Creatina', 'Suplemento', 0.00, 0.00, 0.00, 0.00), -- Libre de gluten, Vegano, Vegetariano
('Glutamina', 'Suplemento', 0.00, 0.00, 0.00, 0.00), -- Libre de gluten, Vegano, Vegetariano
('Omega-3 (aceite de pescado)', 'Suplemento', 902.00, 0.00, 0.00, 100.00), -- Libre de gluten
('Probióticos', 'Suplemento', 0.00, 0.00, 0.00, 0.00), -- Libre de gluten, Vegano, Vegetariano
('Multivitamínico', 'Suplemento', 0.00, 0.00, 0.00, 0.00); -- Libre de gluten, Vegano, Vegetariano


---------------------------
--Insertar en tabla Receta--
INSERT INTO RECETA (Nombre, Descripcion, Categoria, TipoDieta, TipoDieta2, TotalCalorias, TotalProteinas, TotalCarbohidratos) VALUES
('Revuelto de Claras y Pavo', 'Desayuno muy bajo en carbohidratos. El pavo se puede sustituir por tofu para una opción vegetariana.', 'Desayuno', 'Omnívora', 'Alto en proteína', 200.00, 25.00, 5.00),
('Pudín de Chía y Berries', 'Preparación en frío, ideal para llevar. Es naturalmente dulce y no tiene azúcares añadidos.', 'Desayuno', 'Vegana', 'Libre de gluten', 280.00, 10.00, 35.00),
('Tostada con Aguacate y Huevo', 'Clásico desayuno completo. El pan integral contiene gluten. Se puede usar pan sin gluten para adaptarlo.', 'Desayuno', 'Vegetariana', 'Alto en proteína', 350.00, 18.00, 30.00),
('Batido Proteico (Verde)', 'Bebida rápida y muy alta en proteína. Se puede usar proteína de suero o proteína vegetal.', 'Desayuno', 'Omnívora', 'Alto en proteína', 320.00, 35.00, 25.00),
('Avena con Plátano y Leche', 'Desayuno energético con cereales y fruta. Contiene lactosa.', 'Desayuno', 'Vegetariana', 'Sin azúcares añadidos', 400.00, 15.00, 60.00),


-- 2. ALMUERZOS
('Salmón, Brócoli y Quinoa', 'Comida balanceada, alta en omega-3 y proteína. Libre de gluten por naturaleza.', 'Almuerzo', 'Omnívora', 'Libre de gluten', 420.00, 30.00, 35.00),
('Tofu, Arroz y Lentejas', 'Plato vegano muy completo en proteína. Se utiliza arroz integral en lugar de blanco.', 'Almuerzo', 'Vegana', 'Alto en proteína', 450.00, 28.00, 55.00),
('Ensalada de Garbanzos', 'Opción muy fresca y ligera. Se puede añadir queso fresco para una opción vegetariana.', 'Almuerzo', 'Vegana', 'Bajo en grasa', 300.00, 15.00, 45.00),
('Enchiladas de Pollo (Maíz)', 'Plato mexicano adaptable. Las tortillas de maíz son libres de gluten.', 'Almuerzo', 'Omnívora', 'Libre de gluten', 480.00, 38.00, 40.00),
('Ternera y Batata Asada', 'Comida ideal para aumento de masa muscular. Se debe controlar la porción de ternera por su grasa.', 'Almuerzo', 'Omnívora', 'Alto en proteína', 550.00, 45.00, 30.00),


-- 3. CENAS
('Sopa de Lentejas', 'Cena tradicional reconfortante. Naturalmente vegana y vegetariana.', 'Cena', 'Vegana', 'Bajo en grasa', 250.00, 15.00, 40.00), -- 11
('Yogur Griego con Berries', 'Cena o snack nocturno ligero. Es rico en proteína y bajo en carbohidratos si se usa yogur sin azúcar.', 'Cena', 'Vegetariana', 'Bajo en carbohidratos', 220.00, 20.00, 15.00),
('Pollo al Horno y Ensalada', 'Cena muy limpia y baja en grasa. Ideal para metas de pérdida de peso.', 'Cena', 'Omnívora', 'Bajo en carbohidratos', 320.00, 40.00, 8.00),
('Bacalao y Pimientos Asados', 'Pescado blanco magro. Alto en proteína y muy bajo en carbohidratos y grasas.', 'Cena', 'Omnívora', 'Bajo en grasa', 300.00, 35.00, 10.00), 
('Curry de Tempeh y Coco', 'Cena vegana con proteínas vegetales. La leche de coco aporta grasa, pero es una alternativa sin lactosa.', 'Cena', 'Vegana', 'Intolerante a la lactosa', 400.00, 25.00, 25.00),


-- 4. SNACKS (RecetaID 16 - 20)
('Edamame al Vapor', 'Snack de legumbre simple, muy alto en proteína.', 'Snack', 'Vegana', 'Alto en proteína', 180.00, 17.00, 14.00), -- 16
('Requesón con Manzana', 'Snack vegetariano de lácteo. Aporta caseína para liberación lenta de proteína.', 'Snack', 'Vegetariana', 'Bajo en grasa', 150.00, 12.00, 15.00),
('Batido de Proteína (Rápido)', 'Snack de emergencia post-entrenamiento.', 'Snack', 'Omnívora', 'Alto en proteína', 120.00, 25.00, 3.00),
('Hummus y Zanahoria', 'Snack vegetal fresco. El hummus es una buena fuente de carbohidratos y grasa saludable.', 'Snack', 'Vegana', 'Libre de gluten', 210.00, 8.00, 25.00),
('Pavo y Queso Cottage', 'Snack muy bajo en carbohidratos y alto en proteína.', 'Snack', 'Omnívora', 'Bajo en carbohidratos', 140.00, 22.00, 4.00);

-------------------------------------
--Insertar en tabla Ingrediente-Receta
-- Receta 1: Revuelto de Claras y Pavo
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(1, 40, '5 claras'), -- Claras de huevo
(1, 30, '50 gramos'), -- Jamón de pavo
(1, 21, '50 gramos'); -- Espinacas

-- Receta 2: Pudín de Chía y Berries
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(2, 56, '2 cdas'), -- Semillas de chía
(2, 53, '200 ml'), -- Leche de almendras
(2, 9, '80 gramos'); -- Frutos rojos

-- Receta 3: Tostada con Aguacate y Huevo
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(3, 4, '1 rebanada'), -- Pan integral
(3, 11, '1/2 unidad'), -- Aguacate
(3, 39, '1 unidad'); -- Huevo entero

-- Receta 4: Batido Proteico (Verde)
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(4, 62, '1 scoop'), -- Proteína en polvo
(4, 8, '1/2 unidad'), -- Plátano
(4, 21, '50 gramos'); -- Espinacas

-- Receta 5: Avena con Plátano y Leche
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(5, 3, '1/2 taza'), -- Avena en hojuelas
(5, 42, '150 ml'), -- Leche de vaca
(5, 8, '1 unidad'); -- Plátano

-- Receta 6: Salmón, Brócoli y Quinoa
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(6, 33, '120 gramos'), -- Salmón
(6, 22, '100 gramos'), -- Brócoli
(6, 1, '1/2 taza'); -- Quinoa cocida

-- Receta 7: Tofu, Arroz y Lentejas
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(7, 45, '100 gramos'), -- Tofu firme
(7, 2, '1/2 taza'), -- Arroz integral
(7, 48, '1/4 taza'); -- Lentejas rojas

-- Receta 8: Ensalada de Garbanzos
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(8, 15, '1 taza'), -- Garbanzos cocidos
(8, 25, '2 tazas'), -- Lechuga
(8, 26, '1/2 unidad'); -- Tomate

-- Receta 9: Enchiladas de Pollo (Maíz)
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(9, 32, '100 gramos'), -- Pollo deshebrado
(9, 5, '3 unidades'), -- Tortilla de maíz
(9, 29, '50 gramos'); -- Carne molida magra (para salsa o relleno)

-- Receta 10: Ternera y Batata Asada
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(10, 31, '150 gramos'), -- Filete de ternera
(10, 23, '1 unidad'); -- Batata (camote)

-- Receta 11: Sopa de Lentejas
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(11, 16, '1 taza'), -- Lentejas cocidas
(11, 27, '1/2 unidad'), -- Zanahoria
(11, 26, '1/2 unidad'); -- Tomate

-- Receta 12: Yogur Griego con Berries
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(12, 41, '150 gramos'), -- Yogur griego
(12, 9, '50 gramos'); -- Frutos rojos

-- Receta 13: Pollo al Horno y Ensalada
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(13, 28, '150 gramos'), -- Pechuga de pollo
(13, 25, '1 taza'), -- Lechuga
(13, 26, '1/2 unidad'); -- Tomate

-- Receta 14: Bacalao y Pimientos Asados
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(14, 36, '120 gramos'), -- Bacalao
(14, 24, '1 unidad'); -- Pimientos

-- Receta 15: Curry de Tempeh y Coco
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(15, 47, '100 gramos'), -- Tempeh
(15, 51, '100 ml'); -- Leche de coco

-- Receta 16: Edamame al Vapor
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(16, 17, '1 taza'); -- Edamame

-- Receta 17: Requesón con Manzana
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(17, 44, '100 gramos'), -- Requesón
(17, 10, '1/2 unidad'); -- Manzana

-- Receta 18: Batido de Proteína (Rápido)
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(18, 62, '1 scoop'); -- Proteína en polvo

-- Receta 19: Hummus y Zanahoria
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(19, 20, '50 gramos'), -- Hummus
(19, 27, '1 unidad'); -- Zanahoria

-- Receta 20: Pavo y Queso Cottage
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(20, 30, '4 lonchas'), -- Jamón de pavo
(20, 43, '50 gramos'); -- Queso cottage

--------------------------------------
--Insercion en la tabla Alergias--
INSERT INTO ALERGIA (Nombre, Descripcion) VALUES
('Gluten', 'Proteína presente en cereales como el trigo, la cebada y el centeno.'),
('Lactosa', 'Azúcar natural de la leche y los productos lácteos.'),
('Huevo', 'Alergia a la proteína de la clara o la yema del huevo.'),
('Soja', 'Alergia a la proteína de la soja y sus derivados.'),
('Frutos secos', 'Alergia a nueces, almendras, pistachos, etc.'),
('Pescado', 'Alergia a peces y mariscos.'),
('Fructosa', 'Intolerancia al azúcar natural presente en muchas frutas y algunas verduras.');

--------------------------------------------
--Insercion en la tabla Alergia-Alimento--
-- Alergia: Gluten (AlergiaID = 1)
INSERT INTO ALERG_ALIMENTO (AlergiaID, AlimentoID) VALUES
(1, 3), -- Avena en hojuelas
(1, 4), -- Pan integral
(1, 6), -- Couscous
(1, 46), -- Seitan

-- Alergia: Lactosa (AlergiaID = 2)
(2, 41), -- Yogur griego
(2, 42), -- Leche de vaca
(2, 43), -- Queso cottage
(2, 44), -- Requesón

-- Alergia: Huevo (AlergiaID = 3)
(3, 39), -- Huevo entero
(3, 40), -- Claras de huevo

-- Alergia: Soja (AlergiaID = 4)
(4, 17), -- Edamame
(4, 45), -- Tofu firme
(4, 54), -- Leche de soja
(4, 55), -- Yogur de soja

-- Alergia: Frutos secos (AlergiaID = 5)
(5, 53), -- Leche de almendras
(5, 56), -- Semillas de chía
(5, 57), -- Semillas de lino
(5, 58), -- Semillas de calabaza
(5, 59), -- Semillas de sésamo
(5, 60), -- Semillas de girasol
(5, 61), -- Semillas de cáñamo

-- Alergia: Pescado (AlergiaID = 6)

(6, 33), -- Salmón
(6, 34), -- Atún en agua
(6, 35), -- Tilapia
(6, 36), -- Bacalao
(6, 37), -- Merluza

-- Alergia: Fructosa (AlergiaID = 7)
(7, 8), -- Plátano
(7, 9), -- Frutos rojos
(7, 10), -- Manzana
(7, 11), -- Aguacate
(7, 12), -- Fresa
(7, 13), -- Mango
(7, 14); -- Naranja
