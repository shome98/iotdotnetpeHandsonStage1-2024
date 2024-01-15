select distinct(h.hotel_id), h.hotel_name, h.rating
from hotel_details h, orders o
where extract(month from o.order_date) = 7 and o.hotel_id = h.hotel_id
order by h.hotel_id;
