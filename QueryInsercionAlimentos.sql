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
INSERT INTO RECETA (Nombre, Descripcion, Categoria, TotalCalorias, TotalProteinas, TotalCarbohidratos) VALUES
('Revuelto de Claras con Espinacas y Pavo', 'Receta baja en carbohidratos y alta en proteína. Es libre de gluten. Para una opción vegetariana, se puede omitir el pavo.', 'Desayuno', 200.00, 25.00, 5.00),
('Avena de Quinoa de Noche', 'Receta apta para veganos y vegetarianos, y libre de gluten. Utiliza leche vegetal y frutos rojos para un desayuno completo y saludable.', 'Desayuno', 250.00, 10.00, 35.00),
('Pudín de Chía y Proteína', 'Snack o desayuno alto en proteína. Vegano, vegetariano y libre de gluten. Se puede usar proteína en polvo vegetal para mantener la opción vegana.', 'Desayuno', 300.00, 25.00, 30.00),
('Tortitas de Plátano y Huevo', 'Tortitas caseras, sin gluten y vegetarianas. Ideal para un desayuno rápido y energético. Se pueden acompañar con miel o frutas.', 'Desayuno', 230.00, 12.00, 30.00),
('Salmón a la Plancha con Brócoli', 'Plato principal alto en proteínas y bajo en carbohidratos, completamente libre de gluten. Se cocina rápidamente y es muy saludable.', 'Almuerzo', 350.00, 25.00, 10.00),
('Pechuga de Pollo al Horno con Batata', 'Receta simple y nutritiva, alta en proteína. Se puede sazonar al gusto y es libre de gluten.', 'Almuerzo', 380.00, 30.00, 30.00),
('Tofu Revuelto con Verduras', 'Una excelente alternativa vegana y vegetariana al huevo revuelto. Libre de gluten y muy versátil con cualquier verdura.', 'Almuerzo', 200.00, 18.00, 8.00),
('Ensalada de Atún y Garbanzos', 'Comida rápida y fresca, alta en proteínas. Libre de gluten. Ideal para un almuerzo ligero.', 'Almuerzo', 350.00, 35.00, 30.00),
('Lentejas Estofadas con Verduras', 'Plato tradicional, ideal para una cena nutritiva y reconfortante. Completamente vegano, vegetariano y libre de gluten.', 'Cena', 220.00, 15.00, 40.00),
('Enchiladas de Pollo con Tortillas de Maíz', 'Cena alta en proteínas, libre de gluten. Se pueden adaptar con carne molida o proteína vegetal (como lentejas) para otras opciones.', 'Cena', 280.00, 30.00, 30.00),
('Calabacín Relleno de Carne Molida', 'Receta baja en carbohidratos, alta en proteína y libre de gluten. Se puede rellenar con carne vegetal para una opción vegana.', 'Cena', 350.00, 30.00, 10.00),
('Huevos Duros (2 Unidades)', 'Snack clásico, alto en proteínas y bajo en carbohidratos. Es vegetariano y libre de gluten.', 'Snack', 140.00, 12.00, 1.00),
('Batido de Proteína y Plátano', 'Snack post-entrenamiento, alto en proteínas. Se puede usar proteína de suero o proteína vegana.', 'Snack', 200.00, 25.00, 20.00),
('Edamame al Vapor', 'Snack vegano, vegetariano y libre de gluten, muy alto en proteína. Es una alternativa saludable a los snacks procesados.', 'Snack', 180.00, 17.00, 14.00),
('Jamón de Pavo con Palitos de Zanahoria', 'Snack bajo en carbohidratos y alto en proteína. Libre de gluten. Una opción rápida y sencilla.', 'Snack', 80.00, 12.00, 2.00);

-------------------------------------
--Insertar en tabla Ingrediente-Receta
-- Receta: Revuelto de Claras con Espinacas y Pavo
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(1, 40, '5 claras'), -- Alimento: Claras de huevo
(1, 30, '50g'), -- Alimento: Jamón de pavo
(1, 21, '50g'), -- Alimento: Espinacas

-- Receta: Avena de Quinoa de Noche
(2, 1, '1/3 taza'), -- Alimento: Quinoa cocida
(2, 53, '1/2 taza'), -- Alimento: Leche de almendras
(2, 56, '1 cda.'), -- Alimento: Semillas de chía
(2, 9, '1/2 taza'), -- Alimento: Frutos rojos

-- Receta: Pudín de Chía y Proteína
(3, 56, '2 cdas.'), -- Alimento: Semillas de chía
(3, 62, '1 scoop'), -- Alimento: Proteína en polvo
(3, 53, '3/4 taza'), -- Alimento: Leche de almendras
(3, 8, '1/2 plátano'), -- Alimento: Plátano

-- Receta: Tortitas de Plátano y Huevo
(4, 8, '1 unidad'), -- Alimento: Plátano
(4, 39, '2 unidades'), -- Alimento: Huevo entero

-- Receta: Salmón a la Plancha con Brócoli
(5, 33, '100g'), -- Alimento: Salmón
(5, 22, '150g'), -- Alimento: Brócoli

-- Receta: Pechuga de Pollo al Horno con Batata
(6, 28, '120g'), -- Alimento: Pechuga de pollo
(6, 23, '1 unidad'), -- Alimento: Batata (camote)

-- Receta: Tofu Revuelto con Verduras
(7, 45, '150g'), -- Alimento: Tofu firme
(7, 24, '100g'), -- Alimento: Pimientos

-- Receta: Ensalada de Atún y Garbanzos
(8, 34, '1 lata'), -- Alimento: Atún en agua
(8, 15, '1/2 taza'), -- Alimento: Garbanzos cocidos
(8, 25, '1 taza'), -- Alimento: Lechuga
(8, 26, '1/2 unidad'), -- Alimento: Tomate

-- Receta: Lentejas Estofadas con Verduras
(9, 16, '1/2 taza'), -- Alimento: Lentejas cocidas
(9, 27, '1/4 taza'), -- Alimento: Zanahoria
(9, 26, '1/4 taza'), -- Alimento: Tomate

-- Receta: Enchiladas de Pollo con Tortillas de Maíz
(10, 32, '100g'), -- Alimento: Pollo deshebrado
(10, 5, '2 unidades'), -- Alimento: Tortilla de maíz
(10, 26, '1/2 taza'), -- Alimento: Tomate

-- Receta: Calabacín Relleno de Carne Molida
(11, 24, '1 unidad'), -- Alimento: Pimientos
(11, 29, '100g'), -- Alimento: Carne molida magra

-- Receta: Huevos Duros (2 Unidades)
(12, 39, '2 unidades'), -- Alimento: Huevo entero

-- Receta: Batido de Proteína y Plátano
(13, 62, '1 scoop'), -- Alimento: Proteína en polvo
(13, 8, '1/2 unidad'), -- Alimento: Plátano

-- Receta: Edamame al Vapor
(14, 17, '1 taza'), -- Alimento: Edamame

-- Receta: Jamón de Pavo con Palitos de Zanahoria
(15, 30, '4 lonchas'), -- Alimento: Jamón de pavo
(15, 27, '1/2 unidad'); -- Alimento: Zanahoria

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
