select * from ENTRADAS



select  format(e.fecha_entrada,'dd/MM/yyyy') Fecha, c.apellido_cliente +' '+c.nombre_cliente Cliente, p.nombre_pelicula
	from ENTRADAS e join CLIENTES c on e.id_cliente =c.id_cliente
		join FUNCIONES f on e.id_funcion = f.id_funcion
		join PELICULAS p on p.id_pelicula = f.id_pelicula



		select   p.nombre_pelicula Pelicula,i.idioma Idioma, c.descripcion Clasificación, h.horario Horario
				from FUNCIONES f join PELICULAS p on p.id_pelicula = f.id_pelicula
					join HORARIOS_FUNCIONES h on f.id_horario_funcion = h.id_horario_funcion
					join IDIOMAS i on p.id_idioma= i.id_idioma
					join CLASIFICACIONES c on p.id_clasificacion=c.id_clasificacion
	
	


	select ds.id_detalle_sala Sala,ds.descripcion Descripción,tp.caracteristica Característica
	from DETALLES_SALAS ds join SALAS s on ds.id_sala =s.id_sala
		join TIPOS_SALAS tp on s.id_tipo_sala = tp.id_tipo_sala
				
	
	use CINE_CORDOBA

		select p.nombre_pelicula Película, nombre Director, clasificacion Clasificación, format(fecha_estreno, 'dd/MM/yyyy') Estreno
	from PELICULAS p join CLASIFICACIONES c on p.id_clasificacion=c.id_clasificacion
					 join DIRECTORES d on d.id_director = p.id_director
				