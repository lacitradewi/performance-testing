TYPE=VIEW
query=select `akademik`.`dt_jadwal`.`hri` AS `hri`,`akademik`.`dt_jadwal`.`kd_pljrn` AS `kd_pljrn`,`akademik`.`dt_pljr`.`nm_pljrn` AS `nm_pljrn`,`akademik`.`dt_jadwal`.`jm_pljrn` AS `jm_pljrn`,`akademik`.`dt_guru`.`nm_guru` AS `nm_guru` from `akademik`.`dt_jadwal` join `akademik`.`dt_guru` join `akademik`.`dt_pljr` where ((`akademik`.`dt_jadwal`.`kd_pljrn` = `akademik`.`dt_pljr`.`kd_pljrn`) and (`akademik`.`dt_jadwal`.`kd_gr` = `akademik`.`dt_guru`.`kd_gr`))
md5=04a545379dafd4c10dee1ec16a51ef4d
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
revision=1
timestamp=2015-04-08 14:53:54
create-version=1
source=select hri,dt_jadwal.kd_pljrn,nm_pljrn,jm_pljrn,nm_guru from dt_jadwal,dt_guru,dt_pljr where dt_jadwal.kd_pljrn = dt_pljr.kd_pljrn and dt_jadwal.kd_gr = dt_guru.kd_gr
