--GERA VALDEZ--01--
select C.nombre_cliente +' '+C.apellido_cliente Cliente, count(*) Cantidad, month(fecha_entrada) Mes, year(fecha_entrada) Año
from ENTRADAS e join CLIENTES c on e.id_cliente = C.id_cliente
where c.id_cliente in (select c.id_cliente
					   from COMPROBANTES comp join DETALLES_COMPROBANTES dc on comp.id_detalle_comprobante = dc.id_detalle_comprobante
							join FORMAS_PAGOS fc on fc.id_forma_pago = dc.id_forma_pago join ENTRADAS e on e.id_entrada = comp.id_entrada 
					   where (c.id_cliente = e.id_cliente)and forma_pago ='Efectivo') and (DATEDIFF(MONTH, fecha_entrada, getdate()) = 1)
group by C.nombre_cliente +' '+C.apellido_cliente, month(fecha_entrada), year(fecha_entrada)
having count(*)>1

--GERA VALDEZ--02--
select c.clasificacion Clasificación, c.descripcion 'Descripción', count(*) Concurrencia,'Hace 3 meses ' Meses
from ENTRADAS e join FUNCIONES f on e.id_funcion = f.id_funcion 
				join  PELICULAS p on p.id_pelicula = f.id_pelicula 
				join CLASIFICACIONES c on c.id_clasificacion = p.id_clasificacion
where datediff(month,e.fecha_entrada,getdate()) = 3 
group by  c.clasificacion, c.descripcion
having count(*) > 50


union
select c.clasificacion, c.descripcion, count(*),'Hace 2 meses '
from ENTRADAS e join FUNCIONES f on e.id_funcion = f.id_funcion 
				join  PELICULAS p on p.id_pelicula = f.id_pelicula 
				join CLASIFICACIONES c on c.id_clasificacion = p.id_clasificacion
where datediff(month,e.fecha_entrada,getdate()) = 2
group by  c.clasificacion, c.descripcion
having count(*) >50
order by 3,2

--================================================================================--

--YASS MERCADO--01--
select PEL.nombre_pelicula PELICULAS, CONVERT(varchar, ENT.fecha_entrada,3) FECHA, CAST(DET.descuento as varchar) + '%' DESCUENTO,
	   COM.monto MONTO, COM.cantidad CANTIDAD
from DETALLES_COMPROBANTES DDC join COMPROBANTES COM on DDC.id_detalle_comprobante = COM.id_detalle_comprobante
						   join ENTRADAS ENT on COM.id_entrada = ENT.id_entrada
						   join DESCUENTOS DET on DDC.id_descuento = DET.id_descuento
						   join FUNCIONES FUN on FUN.id_funcion = ENT.id_entrada
						   join PELICULAS PEL on PEL.id_pelicula = PEL.id_pelicula
where DDC.id_forma_pago in (select FDP.id_forma_pago
						   from FORMAS_PAGOS FDP
						   where FDP.id_forma_pago = DDC.id_forma_pago and
						   FDP.forma_pago like '%tarjeta%')
	  and datediff(MONTH, fecha_entrada, GETDATE()) = 3
	  and DET.descuento > 20
order by 3

--YASS MERCADO--02--
select BUT.fila + CAST(BUT.numero as varchar) BUTACA, CLI.nombre_cliente + ' ' + CLI.apellido_cliente CLINTE,
	   COUNT(fecha_entrada) ASISTENCIAS
from BUTACAS BUT join DETALLES_SALAS DDS on BUT.id_butaca=DDS.id_butaca
				 join ENTRADAS ENT on DDS.id_detalle_sala=ENT.id_detalle_sala
				 join CLIENTES CLI on CLI.id_cliente=ENT.id_cliente
				 join FUNCIONES FUN on FUN.id_funcion=ENT.id_funcion
				 join PELICULAS PEL on PEL.id_pelicula=FUN.id_pelicula
where exists (select CLA.clasificacion
			 from CLASIFICACIONES CLA
			 where CLA.clasificacion = 'G')
group by BUT.fila + CAST(BUT.numero as varchar), CLI.nombre_cliente + ' ' + CLI.apellido_cliente
having COUNT(fecha_entrada)>3
order by 3 desc

--================================================================================--

--TOTI PICONE--01--
SELECT SUM(en.id_cliente) AS Clientes, CONVERT(varchar, en.fecha_entrada, 103)  AS Fecha
FROM ENTRADAS AS en INNER JOIN CLIENTES AS c ON c.id_cliente = en.id_cliente 
					INNER JOIN FUNCIONES AS f ON f.id_funcion = en.id_funcion
WHERE EXISTS (SELECT horario
              FROM HORARIOS_FUNCIONES
			  WHERE (horario NOT BETWEEN '10:00:00' AND '16:00:00')) AND (en.fecha_entrada BETWEEN '08/01/2022' AND '08/31/2022')
GROUP BY en.fecha_entrada
ORDER BY Fecha

--TOTI PICONE--02--
select p.nombre_pelicula Pelicula, SUM(c.monto) Total, COUNT(ds.id_butaca) Butacas
from COMPROBANTES c join DETALLES_COMPROBANTES dc on dc.id_detalle_comprobante = c.id_detalle_comprobante
					join ENTRADAS en on en.id_entrada = c.id_entrada
					join DETALLES_SALAS ds on ds.id_detalle_sala = en.id_detalle_sala
					join SALAS sa on sa.id_sala = ds.id_sala
					join FUNCIONES fu on fu.id_funcion = en.id_funcion
					join PELICULAS p on p.id_pelicula = fu.id_pelicula
					join BUTACAS b on b.id_butaca = ds.id_butaca
group by p.nombre_pelicula
having SUM(c.monto) > (select AVG(cantidad*monto)
						from COMPROBANTES)
	   and COUNT(ds.id_butaca) < 10

--================================================================================--

--GONZA CORREA--01--
select sum(Monto) Recaudacion, p.nombre_pelicula
from COMPROBANTES c join ENTRADAS e on c.id_entrada = e.id_entrada
					join FUNCIONES f on e.id_funcion = f.id_funcion
					join PELICULAS p on f.id_pelicula = p.id_pelicula
					join DIRECTORES d on p.id_director = d.id_director
					join IDIOMAS i on p.id_idioma = i.id_idioma
where d.nombre like 'Steven Spielberg' and i.idioma like 'Castellano'
									   and day(e.fecha_entrada) between 1 and 15
									   and MONTH(e.fecha_entrada) = 8
group by p.nombre_pelicula

--GONZA CORREA--02--
select sum(c.monto) 'Monto Total', Metodo = 'Efectivo'
from COMPROBANTES c join DETALLES_COMPROBANTES d on c.id_detalle_comprobante = d.id_detalle_comprobante
					join FORMAS_PAGOS fp on d.id_forma_pago = fp.id_forma_pago
					join FORMAS_COMPRAS fc on c.id_forma_compra = fc.id_forma_compra
					join ENTRADAS e on c.id_entrada = e.id_entrada
where fp.forma_pago = 'Efectivo' and DATEDIFF(month,e.fecha_entrada,GETDATE())!=0
								 and fc.descripcion like 'No Presencial'
UNION
select sum(c.monto) 'Monto Total', Metodo = 'Tarjeta Debito'
from COMPROBANTES c join DETALLES_COMPROBANTES d on c.id_detalle_comprobante = d.id_detalle_comprobante
					join FORMAS_PAGOS fp on d.id_forma_pago = fp.id_forma_pago
					join FORMAS_COMPRAS fc on c.id_forma_compra = fc.id_forma_compra
					join ENTRADAS e on c.id_entrada = e.id_entrada
where fp.forma_pago = 'Tarjeta Debito' and DATEDIFF(month,e.fecha_entrada,GETDATE())!=0 
									   and fc.descripcion like 'No Presencial'
UNION
select sum(c.monto) 'Monto Total', Metodo = 'Tarjeta Credito'
from COMPROBANTES c join DETALLES_COMPROBANTES d on c.id_detalle_comprobante = d.id_detalle_comprobante
					join FORMAS_PAGOS fp on d.id_forma_pago = fp.id_forma_pago
					join FORMAS_COMPRAS fc on c.id_forma_compra = fc.id_forma_compra
					join ENTRADAS e on c.id_entrada = e.id_entrada
where fp.forma_pago = 'Tarjeta Credito' and DATEDIFF(month,e.fecha_entrada,GETDATE())!=0 
									    and fc.descripcion like 'No Presencial'

--================================================================================--

--Cruz Aviles, Héctor Gonzalo--01--
select COUNT(E.id_entrada) ENTRADAS, 'DE 00:00 HS - 10:00 HS' RANGO
from ENTRADAS E join funciones F on E.id_funcion = E.id_funcion
				join HORARIOS_FUNCIONES HF on HF.id_horario_funcion = F.id_horario_funcion
where HF.horario > '00:00:00' and HF.horario < '10:00:00'
UNION
select COUNT(E.id_entrada) ENTRADAS, 'DE 10:00 HS - 14:00 HS'
from ENTRADAS E join funciones F on E.id_funcion = E.id_funcion
				join HORARIOS_FUNCIONES HF on HF.id_horario_funcion = F.id_horario_funcion
where HF.horario > '10:00:00' and HF.horario < '14:00:00'
UNION
select COUNT(E.id_entrada) ENTRADAS, 'DE 14:00 HS - 18:00 HS'
from ENTRADAS E join funciones F on E.id_funcion = E.id_funcion
				join HORARIOS_FUNCIONES HF on HF.id_horario_funcion = F.id_horario_funcion
where HF.horario > '14:00:00' and HF.horario < '18:00:00'
UNION
select COUNT(E.id_entrada) ENTRADAS, 'DE 18:00 HS - 00:00 HS'
from ENTRADAS E join funciones F on E.id_funcion = E.id_funcion
				join HORARIOS_FUNCIONES HF on HF.id_horario_funcion = F.id_horario_funcion
where HF.horario > '18:00:00' and HF.horario < '00:00:00'
ORDER BY 1 desc

--Cruz Aviles, Héctor Gonzalo--02--
SELECT TOP 5 P.nombre_pelicula PELICULA, COUNT(*) VENDIDAS
FROM ENTRADAS E join FUNCIONES F on E.id_funcion = f.id_funcion
				join PELICULAS P on P.id_pelicula = F.id_funcion
				join IDIOMAS I on I.id_idioma = P.id_idioma
where DATEDIFF(YEAR, E.fecha_entrada, GETDATE())=0 and MONTH(E.fecha_entrada)=8
	  and I.idioma = 'Castellano' or I.idioma = 'Ingles'
group by P.nombre_pelicula
order by 2 desc
--================================================================================--