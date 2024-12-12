`drgrr`SELECT cat_id, MAX(shop_price)`drgrr``事件``drgrr``drgrr``drgrr``drgrr`
	FROM ecs_goods
	GROUP BY cat_id


SELECT goods_id, ecs_goods.cat_id,goods_name,shop_price 
	FROM (
		SELECT cat_id, MAX(shop_price) AS max_price
		FROM ecs_goods
		GROUP BY cat_id
	) temp,ecs_goods
	WHERE temp.cat_id = ecs_goods.cat_id
	AND temp.max_price= ecs_goods.shop_price



SELECT goods_id, ecs_good.cat_id,goods_name,shop_price 

	FROM ecs_goods
	
SELECT *
	FROM ecs_goods