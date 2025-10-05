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

('Salmón, Brócoli y Quinoa', 'Comida balanceada, alta en omega-3 y proteína. Libre de gluten por naturaleza.', 'Almuerzo', 'Omnívora', 'Libre de gluten', 420.00, 30.00, 35.00),
('Tofu, Arroz y Lentejas', 'Plato vegano muy completo en proteína. Se utiliza arroz integral en lugar de blanco.', 'Almuerzo', 'Vegana', 'Alto en proteína', 450.00, 28.00, 55.00),
('Ensalada de Garbanzos', 'Opción muy fresca y ligera. Se puede añadir queso fresco para una opción vegetariana.', 'Almuerzo', 'Vegana', 'Bajo en grasa', 300.00, 15.00, 45.00),
('Enchiladas de Pollo (Maíz)', 'Plato mexicano adaptable. Las tortillas de maíz son libres de gluten.', 'Almuerzo', 'Omnívora', 'Libre de gluten', 480.00, 38.00, 40.00),
('Ternera y Batata Asada', 'Comida ideal para aumento de masa muscular. Se debe controlar la porción de ternera por su grasa.', 'Almuerzo', 'Omnívora', 'Alto en proteína', 550.00, 45.00, 30.00),

('Sopa de Lentejas', 'Cena tradicional reconfortante. Naturalmente vegana y vegetariana.', 'Cena', 'Vegana', 'Bajo en grasa', 250.00, 15.00, 40.00), -- 11
('Yogur Griego con Berries', 'Cena o snack nocturno ligero. Es rico en proteína y bajo en carbohidratos si se usa yogur sin azúcar.', 'Cena', 'Vegetariana', 'Bajo en carbohidratos', 220.00, 20.00, 15.00),
('Pollo al Horno y Ensalada', 'Cena muy limpia y baja en grasa. Ideal para metas de pérdida de peso.', 'Cena', 'Omnívora', 'Bajo en carbohidratos', 320.00, 40.00, 8.00),
('Bacalao y Pimientos Asados', 'Pescado blanco magro. Alto en proteína y muy bajo en carbohidratos y grasas.', 'Cena', 'Omnívora', 'Bajo en grasa', 300.00, 35.00, 10.00), 
('Curry de Tempeh y Coco', 'Cena vegana con proteínas vegetales. La leche de coco aporta grasa, pero es una alternativa sin lactosa.', 'Cena', 'Vegana', 'Intolerante a la lactosa', 400.00, 25.00, 25.00),

('Edamame al Vapor', 'Snack de legumbre simple, muy alto en proteína.', 'Snack', 'Vegana', 'Alto en proteína', 180.00, 17.00, 14.00), -- 16
('Requesón con Manzana', 'Snack vegetariano de lácteo. Aporta caseína para liberación lenta de proteína.', 'Snack', 'Vegetariana', 'Bajo en grasa', 150.00, 12.00, 15.00),
('Batido de Proteína (Rápido)', 'Snack de emergencia post-entrenamiento.', 'Snack', 'Omnívora', 'Alto en proteína', 120.00, 25.00, 3.00),
('Hummus y Zanahoria', 'Snack vegetal fresco. El hummus es una buena fuente de carbohidratos y grasa saludable.', 'Snack', 'Vegana', 'Libre de gluten', 210.00, 8.00, 25.00),
('Pavo y Queso Cottage', 'Snack muy bajo en carbohidratos y alto en proteína.', 'Snack', 'Omnívora', 'Bajo en carbohidratos', 140.00, 22.00, 4.00),


('Bowl de Tilapia y Espinacas', 'Cena o almuerzo muy ligero y bajo en grasa y carbohidratos.', 'Cena', 'Omnívora', 'Bajo en carbohidratos', 250.00, 30.00, 5.00),
('Omelette de Pimientos y Queso', 'Desayuno o cena rápido, alto en proteína y sin cereales.', 'Desayuno', 'Vegetariana', 'Bajo en carbohidratos', 220.00, 20.00, 7.00),
('Snack Alto en Fibra (Lino)', 'Snack con semillas de lino, alto en fibra para saciedad.', 'Snack', 'Vegana', 'Libre de gluten', 150.00, 5.00, 10.00),


('Burrito de Frijoles, Arroz y Pollo', 'Almuerzo denso en calorías y nutrientes, ideal para post-entrenamiento.', 'Almuerzo', 'Omnívora', 'Alto en proteína', 600.00, 45.00, 60.00),
('Batido Alto en Calorías y Proteína', 'Batido para aumentar ingesta calórica de manera práctica.', 'Desayuno', 'Omnívora', 'Alto en proteína', 500.00, 50.00, 40.00),
('Tofu Scramble con Quinoa', 'Desayuno vegano con alto contenido de proteína vegetal y carbohidratos complejos.', 'Desayuno', 'Vegana', 'Alto en proteína', 410.00, 25.00, 45.00),


('Merluza con Batata y Brócoli', 'Plato con proteína magra, carbohidrato complejo y vegetal verde.', 'Almuerzo', 'Omnívora', 'Bajo en grasa', 400.00, 30.00, 35.00),
('Tazón de Couscous y Alubias', 'Comida vegetariana con carbohidratos, legumbres y vegetales frescos.', 'Almuerzo', 'Vegetariana', 'Bajo en grasa', 380.00, 18.00, 50.00),
('Wrap de Pollo y Vegetales', 'Comida balanceada que integra proteína, cereal y vegetales en porciones controladas.', 'Almuerzo', 'Omnívora', 'Ninguno', 430.00, 35.00, 40.00),


('Tazón de Yogur con Mango y Semillas', 'Desayuno fresco con probióticos y fruta.', 'Desayuno', 'Vegetariana', 'Libre de gluten', 320.00, 15.00, 45.00),
('Batido de Fresa y Soja', 'Opción vegana y sin lactosa para un desayuno rápido.', 'Desayuno', 'Vegana', 'Intolerante a la lactosa', 250.00, 10.00, 40.00),
('Claras de Huevo y Aguacate', 'Muy bajo en carbohidratos, alto en proteína y grasa saludable.', 'Desayuno', 'Vegetariana', 'Bajo en carbohidratos', 280.00, 22.00, 5.00),
('Waffles de Proteína (Avena)', 'Desayuno alto en carbohidratos complejos y proteína.', 'Desayuno', 'Omnívora', 'Alto en proteína', 450.00, 30.00, 55.00), 
('Tortilla con Jamón de Pavo', 'Desayuno rápido y salado, alto en proteína.', 'Desayuno', 'Omnívora', 'Alto en proteína', 280.00, 25.00, 15.00),


('Ensalada de Atún y Arroz Integral', 'Almuerzo balanceado, rico en proteína de pescado.', 'Almuerzo', 'Omnívora', 'Bajo en grasa', 410.00, 32.00, 40.00), 
('Pescado Blanco con Couscous y Tomate', 'Comida ligera con carbohidratos complejos y proteína magra.', 'Almuerzo', 'Omnívora', 'Bajo en grasa', 390.00, 28.00, 45.00),
('Frijoles Negros y Batata', 'Almuerzo vegano reconfortante, denso en carbohidratos y fibra.', 'Almuerzo', 'Vegana', 'Libre de gluten', 480.00, 25.00, 70.00),
('Hamburguesa de Ternera y Lechuga', 'Opción baja en carbohidratos usando lechuga en lugar de pan.', 'Almuerzo', 'Omnívora', 'Bajo en carbohidratos', 380.00, 30.00, 10.00),
('Tazón de Garbanzos y Trigo Sarraceno', 'Plato vegetariano completo, libre de gluten.', 'Almuerzo', 'Vegana', 'Libre de gluten', 430.00, 18.00, 65.00),


('Pollo, Pimientos y Brócoli Salteado', 'Cena baja en carbohidratos con mucha verdura.', 'Cena', 'Omnívora', 'Bajo en carbohidratos', 350.00, 38.00, 12.00),
('Salmón y Espinacas', 'Cena nutritiva, alta en grasa saludable (Omega-3) y proteína.', 'Cena', 'Omnívora', 'Alto en proteína', 450.00, 35.00, 5.00), 
('Tempeh con Vegetales (Sin Cereales)', 'Cena vegana ligera y alta en proteína vegetal.', 'Cena', 'Vegana', 'Alto en proteína', 300.00, 22.00, 15.00),
('Queso Cottage y Tomate', 'Cena o snack nocturno muy rápido y bajo en calorías.', 'Cena', 'Vegetariana', 'Bajo en carbohidratos', 180.00, 15.00, 8.00),
('Lentejas con Aguacate', 'Cena vegana con carbohidratos, proteína y grasa saludable.', 'Cena', 'Vegana', 'Libre de gluten', 350.00, 15.00, 40.00),



('Tostada de Requesón y Naranja', 'Desayuno ligero con cítricos, lácteos y pan integral.', 'Desayuno', 'Vegetariana', 'Bajo en grasa', 300.00, 15.00, 40.00),
('Batido de Proteína y Almendras', 'Batido sin lactosa, ideal para la mañana o post-entrenamiento.', 'Desayuno', 'Omnívora', 'Intolerante a la lactosa', 350.00, 30.00, 25.00),
('Omelette de Queso Cottage y Espinacas', 'Desayuno muy alto en proteína y bajo en carbohidratos.', 'Desayuno', 'Vegetariana', 'Bajo en carbohidratos', 250.00, 25.00, 5.00),
('Bowl de Avena y Semillas de Calabaza', 'Desayuno energético con grasa saludable y fibra.', 'Desayuno', 'Vegana', 'Alto en proteína', 420.00, 18.00, 60.00),


('Wrap de Pollo y Aguacate', 'Comida rápida, baja en carbohidratos usando lechuga en lugar de tortilla.', 'Almuerzo', 'Omnívora', 'Bajo en carbohidratos', 350.00, 35.00, 10.00),
('Ensalada de Lentejas y Tomate', 'Plato vegano fresco y muy completo en micronutrientes.', 'Almuerzo', 'Vegana', 'Libre de gluten', 320.00, 15.00, 45.00),
('Arroz Integral con Tofu', 'Almuerzo balanceado, ideal para mantener la energía.', 'Almuerzo', 'Vegana', 'Alto en proteína', 450.00, 25.00, 60.00),
('Pechuga de Pollo y Batata', 'Plato clásico para la ganancia de masa, alto en proteína y carbohidratos.', 'Almuerzo', 'Omnívora', 'Alto en proteína', 500.00, 40.00, 45.00),


('Sopa de Verduras y Ternera', 'Cena caliente y sustanciosa, baja en carbohidratos si se limita la patata.', 'Cena', 'Omnívora', 'Bajo en carbohidratos', 380.00, 30.00, 15.00),
('Merluza y Ensalada de Zanahoria', 'Cena muy baja en grasa y ligera para la noche.', 'Cena', 'Omnívora', 'Bajo en grasa', 280.00, 35.00, 15.00),
('Tofu al Curry y Brócoli', 'Cena vegana con sabor intenso. Sin lácteos.', 'Cena', 'Vegana', 'Intolerante a la lactosa', 350.00, 20.00, 25.00),
('Queso Cottage y Frutos Rojos', 'Cena simple y ligera, perfecta como postre nutritivo.', 'Cena', 'Vegetariana', 'Bajo en carbohidratos', 190.00, 18.00, 15.00),


('Manzana y Requesón', 'Snack clásico balanceado y alto en proteína.', 'Snack', 'Vegetariana', 'Bajo en grasa', 170.00, 14.00, 20.00),
('Edamame Salado', 'Snack de legumbre, alto en proteína y muy saciante.', 'Snack', 'Vegana', 'Alto en proteína', 150.00, 14.00, 10.00),
('Zanahoria y Hummus', 'Snack vegetal con grasa saludable y fibra.', 'Snack', 'Vegana', 'Libre de gluten', 180.00, 6.00, 25.00),
('Batido de Plátano y Leche de Coco', 'Snack energético para recargar glucógeno.', 'Snack', 'Vegana', 'Intolerante a la lactosa', 280.00, 5.00, 45.00);

-------------------------------------
--Insertar en tabla Ingrediente-Receta
-- Receta 1: Revuelto de Claras y Pavo
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(1, 39, '5 claras'), -- CLARAS DE HUEVO (ID 39, ¡Corregido!)
(1, 30, '50 gramos'), -- Jamón de pavo (ID 30)
(1, 21, '50 gramos'); -- Espinacas (ID 21)

-- Receta 2: Pudín de Chía y Berries
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(2, 56, '2 cdas'), -- Semillas de chía (ID 56)
(2, 53, '200 ml'), -- Leche de almendras (ID 53)
(2, 9, '80 gramos'); -- Frutos rojos (ID 9)

-- Receta 3: Tostada con Aguacate y Huevo
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(3, 4, '1 rebanada'), -- Pan integral (ID 4)
(3, 11, '1/2 unidad'), -- Aguacate (ID 11)
(3, 38, '1 unidad'); -- HUEVO ENTERO (ID 38, ajustado)

-- Receta 4: Batido Proteico (Verde)
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(4, 62, '1 scoop'), -- Proteína en polvo (ID 62)
(4, 8, '1/2 unidad'), -- Plátano (ID 8)
(4, 21, '50 gramos'); -- Espinacas (ID 21)

-- Receta 5: Avena con Plátano y Leche
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(5, 3, '1/2 taza'), -- Avena en hojuelas (ID 3)
(5, 41, '150 ml'), -- Leche de vaca (ID 41, ajustado)
(5, 8, '1 unidad'); -- Plátano (ID 8)

-- Receta 6: Salmón, Brócoli y Quinoa
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(6, 33, '120 gramos'), -- Salmón (ID 33)
(6, 22, '100 gramos'), -- Brócoli (ID 22)
(6, 1, '1/2 taza'); -- Quinoa cocida (ID 1)

-- Receta 7: Tofu, Arroz y Lentejas
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(7, 45, '100 gramos'), -- Tofu firme (ID 45)
(7, 2, '1/2 taza'), -- Arroz integral (ID 2)
(7, 48, '1/4 taza'); -- Lentejas rojas (ID 48)

-- Receta 8: Ensalada de Garbanzos
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(8, 15, '1 taza'), -- Garbanzos cocidos (ID 15)
(8, 25, '2 tazas'), -- Lechuga (ID 25)
(8, 26, '1/2 unidad'); -- Tomate (ID 26)

-- Receta 9: Enchiladas de Pollo (Maíz)
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(9, 32, '100 gramos'), -- Pollo deshebrado (ID 32)
(9, 5, '3 unidades'), -- Tortilla de maíz (ID 5)
(9, 29, '50 gramos'); -- Carne molida magra (ID 29)

-- Receta 10: Ternera y Batata Asada
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(10, 31, '150 gramos'), -- Filete de ternera (ID 31)
(10, 23, '1 unidad'); -- Batata (camote) (ID 23)

-- Receta 11: Sopa de Lentejas
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(11, 16, '1 taza'), -- Lentejas cocidas (ID 16)
(11, 27, '1/2 unidad'), -- Zanahoria (ID 27)
(11, 26, '1/2 unidad'); -- Tomate (ID 26)

-- Receta 12: Yogur Griego con Berries
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(12, 40, '150 gramos'), -- YOGUR GRIEGO (ID 40, ajustado)
(12, 9, '50 gramos'); -- Frutos rojos (ID 9)

-- Receta 13: Pollo al Horno y Ensalada
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(13, 28, '150 gramos'), -- Pechuga de pollo (ID 28)
(13, 25, '1 taza'), -- Lechuga (ID 25)
(13, 26, '1/2 unidad'); -- Tomate (ID 26)

-- Receta 14: Bacalao y Pimientos Asados
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(14, 36, '120 gramos'), -- Bacalao (ID 36)
(14, 24, '1 unidad'); -- Pimientos (ID 24)

-- Receta 15: Curry de Tempeh y Coco
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(15, 47, '100 gramos'), -- Tempeh (ID 47)
(15, 51, '100 ml'); -- Leche de coco (ID 51)

-- Receta 16: Edamame al Vapor
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(16, 17, '1 taza'); -- Edamame (ID 17)

-- Receta 17: Requesón con Manzana
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(17, 43, '100 gramos'), -- REQUESÓN (ID 43, ajustado)
(17, 10, '1/2 unidad'); -- Manzana (ID 10)

-- Receta 18: Batido de Proteína (Rápido)
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(18, 62, '1 scoop'); -- Proteína en polvo (ID 62)

-- Receta 19: Hummus y Zanahoria
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(19, 20, '50 gramos'), -- Hummus
(19, 27, '1 unidad'); -- Zanahoria

-- Receta 20: Pavo y Queso Cottage
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(20, 30, '4 lonchas'), -- Jamón de pavo
(20, 42, '50 gramos'); -- QUESO COTTAGE

-- Receta 21: Bowl de Tilapia y Espinacas
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(21, 37, '100 gramos'), -- Tilapia
(21, 21, '1 taza'),    -- Espinacas
(21, 22, '50 gramos'); -- Brócoli

-- Receta 22: Omelette de Pimientos y Queso
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(22, 38, '2 unidades'), -- Huevo entero
(22, 39, '2 claras'),   -- Claras de huevo
(22, 24, '1 unidad'),   -- Pimientos
(22, 42, '30 gramos');  -- Queso cottage

-- Receta 23: Snack Alto en Fibra (Lino)
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(23, 57, '1 cucharada'), -- Semillas de lino
(23, 10, '1/2 unidad');  -- Manzana

-- Receta 24: Burrito de Frijoles, Arroz y Pollo
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(24, 5, '2 unidades'),    -- Tortilla de maíz
(24, 28, '100 gramos'),   -- Pechuga de pollo
(24, 2, '1/2 taza'),      -- Arroz integral
(24, 19, '1/4 taza');     -- Frijoles negros

-- Receta 25: Batido Alto en Calorías y Proteína
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(25, 62, '2 scoops'),    -- Proteína en polvo
(25, 8, '1 unidad'),     -- Plátano
(25, 52, '200 ml');      -- Leche de avena

-- Receta 26: Tofu Scramble con Quinoa
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(26, 45, '150 gramos'),  -- Tofu firme
(26, 1, '1/2 taza'),     -- Quinoa cocida
(26, 21, '1 taza');      -- Espinacas

-- Receta 27: Merluza con Batata y Brócoli
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(27, 37, '100 gramos'),  -- Merluza
(27, 23, '100 gramos'),  -- Batata (camote)
(27, 22, '100 gramos');  -- Brócoli

-- Receta 28: Tazón de Couscous y Alubias
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(28, 6, '1/2 taza'),     -- Couscous
(28, 18, '1/2 taza'),    -- Alubias blancas
(28, 26, '1/2 unidad');  -- Tomate

-- Receta 29: Wrap de Pollo y Vegetales
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(29, 4, '1 rebanada'),   -- Pan integral (usado como base para wrap, alternando con tortilla)
(29, 32, '80 gramos'),   -- Pollo deshebrado
(29, 25, '1 taza'),      -- Lechuga
(29, 11, '30 gramos');   -- Aguacate

-- Receta 30: Tazón de Yogur con Mango y Semillas
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(30, 40, '150 gramos'),  -- Yogur griego (ID 40)
(30, 13, '1/2 unidad'),  -- Mango (ID 13)
(30, 56, '1 cda');       -- Semillas de chía (ID 56)

-- Receta 31: Batido de Fresa y Soja
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(31, 12, '1 taza'),      -- Fresa (ID 12)
(31, 54, '200 ml');      -- Leche de soja (ID 54)

-- Receta 32: Claras de Huevo y Aguacate
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(32, 39, '6 claras'),    -- Claras de huevo (ID 39)
(32, 11, '1/4 unidad');  -- Aguacate (ID 11)

-- Receta 33: Waffles de Proteína (Avena)
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(33, 3, '1/2 taza'),     -- Avena en hojuelas (ID 3)
(33, 62, '1 scoop'),     -- Proteína en polvo (ID 62)
(33, 39, '3 claras');    -- Claras de huevo (ID 39)

-- Receta 34: Tortilla con Jamón de Pavo
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(34, 5, '2 unidades'),   -- Tortilla de maíz (ID 5)
(34, 30, '50 gramos');   -- Jamón de pavo (ID 30)

-- Receta 35: Ensalada de Atún y Arroz Integral
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(35, 34, '1 lata'),      -- Atún en agua (ID 34)
(35, 2, '1/2 taza'),     -- Arroz integral (ID 2)
(35, 25, '1 taza');      -- Lechuga (ID 25)

-- Receta 36: Pescado Blanco con Couscous y Tomate
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(36, 37, '120 gramos'),  -- Merluza (ID 37)
(36, 6, '1/2 taza'),     -- Couscous (ID 6)
(36, 26, '1 unidad');    -- Tomate (ID 26)

-- Receta 37: Frijoles Negros y Batata
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(37, 19, '1 taza'),      -- Frijoles negros (ID 19)
(37, 23, '1 unidad');    -- Batata (camote) (ID 23)

-- Receta 38: Hamburguesa de Ternera y Lechuga
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(38, 31, '150 gramos'),  -- Filete de ternera (ID 31)
(38, 25, '2 hojas'),     -- Lechuga (ID 25)
(38, 26, '2 rodajas');   -- Tomate (ID 26)

-- Receta 39: Tazón de Garbanzos y Trigo Sarraceno
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(39, 15, '1 taza'),      -- Garbanzos cocidos (ID 15)
(39, 7, '1/2 taza'),     -- Trigo sarraceno (ID 7)
(39, 27, '1/2 unidad');  -- Zanahoria (ID 27)

-- Receta 40: Pollo, Pimientos y Brócoli Salteado
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(40, 28, '120 gramos'),  -- Pechuga de pollo (ID 28)
(40, 24, '1 unidad'),    -- Pimientos (ID 24)
(40, 22, '100 gramos');  -- Brócoli (ID 22)

-- Receta 41: Salmón y Espinacas
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(41, 33, '150 gramos'),  -- Salmón (ID 33)
(41, 21, '1 taza');      -- Espinacas (ID 21)

-- Receta 42: Tempeh con Vegetales (Sin Cereales)
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(42, 47, '100 gramos'),  -- Tempeh (ID 47)
(42, 27, '1 unidad'),    -- Zanahoria (ID 27)
(42, 22, '50 gramos');   -- Brócoli (ID 22)

-- Receta 43: Queso Cottage y Tomate
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(43, 42, '100 gramos'),  -- Queso cottage (ID 42)
(43, 26, '1 unidad');    -- Tomate (ID 26)

-- Receta 44: Lentejas con Aguacate
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(44, 16, '1 taza'),      -- Lentejas cocidas (ID 16)
(44, 11, '1/4 unidad');  -- Aguacate (ID 11)

-- Receta 45: Tostada de Requesón y Naranja
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(45, 4, '1 rebanada'),    -- Pan integral (ID 4)
(45, 43, '50 gramos'),    -- Requesón (ID 43)
(45, 14, '1/2 unidad');   -- Naranja (ID 14)

-- Receta 46: Batido de Proteína y Almendras
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(46, 62, '1 scoop'),      -- Proteína en polvo (ID 62)
(46, 53, '200 ml'),       -- Leche de almendras (ID 53)
(46, 8, '1/2 unidad');    -- Plátano (ID 8)

-- Receta 47: Omelette de Queso Cottage y Espinacas
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(47, 38, '1 unidad'),     -- Huevo entero (ID 38)
(47, 39, '3 claras'),     -- Claras de huevo (ID 39)
(47, 42, '30 gramos'),    -- Queso cottage (ID 42)
(47, 21, '50 gramos');    -- Espinacas (ID 21)

-- Receta 48: Bowl de Avena y Semillas de Calabaza
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(48, 3, '1/2 taza'),      -- Avena en hojuelas (ID 3)
(48, 52, '150 ml'),       -- Leche de avena (ID 52)
(48, 58, '1 cda');        -- Semillas de calabaza (ID 58)

-- Receta 49: Wrap de Pollo y Aguacate
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(49, 28, '120 gramos'),   -- Pechuga de pollo (ID 28)
(49, 11, '1/4 unidad'),   -- Aguacate (ID 11)
(49, 25, '2 hojas');      -- Lechuga (ID 25)

-- Receta 50: Ensalada de Lentejas y Tomate
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(50, 16, '1 taza'),       -- Lentejas cocidas (ID 16)
(50, 26, '1 unidad'),     -- Tomate (ID 26)
(50, 25, '1 taza');       -- Lechuga (ID 25)

-- Receta 51: Arroz Integral con Tofu
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(51, 2, '1/2 taza'),      -- Arroz integral (ID 2)
(51, 45, '100 gramos'),   -- Tofu firme (ID 45)
(51, 27, '1/2 unidad');   -- Zanahoria (ID 27)

-- Receta 52: Pechuga de Pollo y Batata
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(52, 28, '150 gramos'),   -- Pechuga de pollo (ID 28)
(52, 23, '1 unidad');     -- Batata (camote) (ID 23)

-- Receta 53: Sopa de Verduras y Ternera
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(53, 31, '100 gramos'),   -- Filete de ternera (ID 31)
(53, 27, '1 unidad'),     -- Zanahoria (ID 27)
(53, 22, '50 gramos');    -- Brócoli (ID 22)

-- Receta 54: Merluza y Ensalada de Zanahoria
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(54, 37, '120 gramos'),   -- Merluza (ID 37)
(54, 27, '1 unidad'),     -- Zanahoria (ID 27)
(54, 25, '1 taza');       -- Lechuga (ID 25)

-- Receta 55: Tofu al Curry y Brócoli
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(55, 45, '100 gramos'),   -- Tofu firme (ID 45)
(55, 51, '50 ml'),        -- Leche de coco (ID 51)
(55, 22, '100 gramos');   -- Brócoli (ID 22)

-- Receta 56: Queso Cottage y Frutos Rojos
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(56, 42, '100 gramos'),   -- Queso cottage (ID 42)
(56, 9, '50 gramos');     -- Frutos rojos (ID 9)

-- Receta 57: Manzana y Requesón
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(57, 10, '1 unidad'),     -- Manzana (ID 10)
(57, 43, '50 gramos');    -- Requesón (ID 43)

-- Receta 58: Edamame Salado
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(58, 17, '1 taza');       -- Edamame (ID 17)

-- Receta 59: Zanahoria y Hummus
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(59, 27, '1 unidad'),     -- Zanahoria (ID 27)
(59, 20, '50 gramos');    -- Hummus (ID 20)

-- Receta 60: Batido de Plátano y Leche de Coco
INSERT INTO INGREDIENTES_RECETA (RecetaID, AlimentoID, Cantidad) VALUES
(60, 8, '1 unidad'),      -- Plátano (ID 8)
(60, 51, '150 ml');       -- Leche de coco (ID 51)

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
