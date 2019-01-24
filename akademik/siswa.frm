TYPE=VIEW
query=select `akademik`.`dt_siswa`.`nisn` AS `nisn`,`akademik`.`dt_nilai`.`nis` AS `nis`,`akademik`.`dt_siswa`.`nm_siswa` AS `nm_siswa`,`akademik`.`dt_sis_skl`.`kls` AS `kls`,`akademik`.`dt_nilai`.`rt_uh` AS `rt_uh`,`akademik`.`dt_nilai`.`rt_tgs` AS `rt_tgs`,`akademik`.`dt_nilai`.`nil_mid` AS `nil_mid`,`akademik`.`dt_nilai`.`nil_smt` AS `nil_smt`,`akademik`.`dt_nilai`.`nil_akhr` AS `nil_akhr` from `akademik`.`dt_siswa` join `akademik`.`dt_sis_skl` join `akademik`.`dt_nilai` where ((`akademik`.`dt_siswa`.`nisn` = `akademik`.`dt_sis_skl`.`nisn`) and (`akademik`.`dt_nilai`.`nis` = `akademik`.`dt_sis_skl`.`nis`)) group by `akademik`.`dt_nilai`.`nis`
md5=f2dc032f75863c49691f1554fb253ecb
updatable=0
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
revision=1
timestamp=2015-04-23 00:10:36
create-version=1
source=select dt_siswa.nisn,dt_nilai.nis,nm_siswa,kls,rt_uh,rt_tgs,nil_mid,nil_smt,nil_akhr from dt_siswa,dt_sis_skl,dt_nilai where dt_siswa.nisn = dt_sis_skl.nisn and dt_nilai.nis = dt_sis_skl.nis group by dt_nilai.nis
