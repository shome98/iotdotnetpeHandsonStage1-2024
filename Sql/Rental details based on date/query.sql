select rental_id, car_id, customer_id , km_driven
FROM RENTALS
WHERE EXTRACT(MONTH FROM RETURN_DATE)=8
order BY rental_id