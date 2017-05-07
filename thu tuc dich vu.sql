create proc DICHVU_GETALL as
begin
	select * from DICHVU
end

create proc DichVu_add(@tendv nvarchar(50), @soluong int, @gia float) as
begin
	insert into DICHVU (TENDV, SOLUONG, GIA)
	values (@tendv, @soluong, @gia)
end

create proc DichVu_update(@madv int, @tendv nvarchar(50), @soluong int, @gia float) as
begin
	update DICHVU
	set TENDV = @tendv, SOLUONG = @soluong, GIA = @gia
	where MADV = @madv
end