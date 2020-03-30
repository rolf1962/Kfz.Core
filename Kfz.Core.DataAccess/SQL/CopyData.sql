insert into kfz_code_first.costType (
	kfz_code_first.costType.costTypeId,
    kfz_code_first.costType.created,
    kfz_code_first.costType.createdBy,
    kfz_code_first.costType.modified,
    kfz_code_first.costType.modifiedBy)
select 
	kfz.tlkp_kostenart.kostenart,
    now(),'Rolf',now(),'Rolf'
from kfz.tlkp_kostenart;

insert into kfz_code_first.vehicleType (
	kfz_code_first.vehicleType.vehicleTypeId,
    kfz_code_first.vehicleType.created,
    kfz_code_first.vehicleType.createdBy,
    kfz_code_first.vehicleType.modified,
    kfz_code_first.vehicleType.modifiedBy)
select 
	kfz.tlkp_fahrzeugart.art,
    now(),'Rolf',now(),'Rolf'
from kfz.tlkp_fahrzeugart;

insert into kfz_code_first.vehicle (
	kfz_code_first.vehicle.vehicleId,
	kfz_code_first.vehicle.licenceNumber,
    kfz_code_first.vehicle.manufacturer,
    kfz_code_first.vehicle.model,
	kfz_code_first.vehicle.VehicleTypeId,
    kfz_code_first.vehicle.created,
    kfz_code_first.vehicle.createdBy,
    kfz_code_first.vehicle.modified,
    kfz_code_first.vehicle.modifiedBy)
select 
	kfz.tbl_fahrzeug.fahrzeug_id,
    kfz.tbl_fahrzeug.kennzeichen,
    kfz.tbl_fahrzeug.hersteller,
    kfz.tbl_fahrzeug.typ,
	kfz.tbl_fahrzeug.art,
    now(),'Rolf',now(),'Rolf'
from kfz.tbl_fahrzeug;

insert into kfz_code_first.cost (
	kfz_code_first.cost.costId,
    kfz_code_first.cost.amount,
    kfz_code_first.cost.costTypeId,
    kfz_code_first.cost.date,
    kfz_code_first.cost.kmNew,
    kfz_code_first.cost.kmOld,
    kfz_code_first.cost.quantity,
    kfz_code_first.cost.remarks,
    kfz_code_first.cost.vehicleId,
    kfz_code_first.cost.created,
    kfz_code_first.cost.createdBy,
    kfz_code_first.cost.modified,
    kfz_code_first.cost.modifiedBy)
select 
	kfz.tbl_kosten.kosten_id,
    kfz.tbl_kosten.betrag,
    kfz.tbl_kosten.kostenart,
    kfz.tbl_kosten.datum,
    kfz.tbl_kosten.`km-neu`,
    kfz.tbl_kosten.`km-alt`,
    kfz.tbl_kosten.menge,
    kfz.tbl_kosten.bemerkung,
    kfz.tbl_kosten.fahrzeug_id,
    now(),'Rolf',now(),'Rolf'
from kfz.tbl_kosten;
