--
-- PostgreSQL database dump
--

-- Dumped from database version 11.13
-- Dumped by pg_dump version 11.13

-- Started on 2022-03-17 15:09:30

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 196 (class 1259 OID 26454)
-- Name: dishes; Type: TABLE; Schema: public; Owner: sunman
--

CREATE TABLE public.dishes (
    id integer NOT NULL,
    name character varying NOT NULL,
    price numeric NOT NULL,
    measurement_unit character varying NOT NULL,
    volume numeric NOT NULL,
    quantity integer DEFAULT 0 NOT NULL,
    cook_time interval NOT NULL,
    CONSTRAINT dishes_cook_time_check CHECK ((cook_time > '00:00:00'::interval)),
    CONSTRAINT menu_price_check CHECK ((price >= (0)::numeric)),
    CONSTRAINT menu_quantity_check CHECK ((quantity >= 0)),
    CONSTRAINT menu_volume_check CHECK ((volume > (0)::numeric))
);


ALTER TABLE public.dishes OWNER TO sunman;

--
-- TOC entry 199 (class 1259 OID 26501)
-- Name: orders; Type: TABLE; Schema: public; Owner: sunman
--

CREATE TABLE public.orders (
    id integer NOT NULL,
    dish_id integer NOT NULL,
    waiter_id integer NOT NULL,
    chef_id integer NOT NULL
);


ALTER TABLE public.orders OWNER TO sunman;

--
-- TOC entry 197 (class 1259 OID 26466)
-- Name: positions; Type: TABLE; Schema: public; Owner: sunman
--

CREATE TABLE public.positions (
    id integer NOT NULL,
    name character varying NOT NULL,
    salary numeric NOT NULL,
    CONSTRAINT positions_salary_check CHECK ((salary >= (0)::numeric))
);


ALTER TABLE public.positions OWNER TO sunman;

--
-- TOC entry 198 (class 1259 OID 26486)
-- Name: workers; Type: TABLE; Schema: public; Owner: sunman
--

CREATE TABLE public.workers (
    id integer NOT NULL,
    full_name character varying NOT NULL,
    position_id integer NOT NULL
);


ALTER TABLE public.workers OWNER TO sunman;

--
-- TOC entry 2839 (class 0 OID 26454)
-- Dependencies: 196
-- Data for Name: dishes; Type: TABLE DATA; Schema: public; Owner: sunman
--

INSERT INTO public.dishes (id, name, price, measurement_unit, volume, quantity, cook_time) VALUES (1, 'Lasagna', 239.00, 'gramm', 200, 5, '00:40:00');
INSERT INTO public.dishes (id, name, price, measurement_unit, volume, quantity, cook_time) VALUES (2, 'Pizza', 599.00, 'gramm', 800, 10, '00:15:00');
INSERT INTO public.dishes (id, name, price, measurement_unit, volume, quantity, cook_time) VALUES (3, 'Borsch', 79.00, 'gramm', 150, 7, '02:00:00');
INSERT INTO public.dishes (id, name, price, measurement_unit, volume, quantity, cook_time) VALUES (4, 'Fish cotlet', 99.00, 'gramm', 100, 8, '01:00:00');
INSERT INTO public.dishes (id, name, price, measurement_unit, volume, quantity, cook_time) VALUES (5, 'Steamed vegetables', 139.00, 'gramm', 200, 6, '01:00:00');


--
-- TOC entry 2842 (class 0 OID 26501)
-- Dependencies: 199
-- Data for Name: orders; Type: TABLE DATA; Schema: public; Owner: sunman
--

INSERT INTO public.orders (id, dish_id, waiter_id, chef_id) VALUES (1, 1, 3, 2);
INSERT INTO public.orders (id, dish_id, waiter_id, chef_id) VALUES (2, 4, 3, 2);
INSERT INTO public.orders (id, dish_id, waiter_id, chef_id) VALUES (3, 5, 3, 2);
INSERT INTO public.orders (id, dish_id, waiter_id, chef_id) VALUES (4, 2, 3, 2);
INSERT INTO public.orders (id, dish_id, waiter_id, chef_id) VALUES (5, 3, 3, 2);


--
-- TOC entry 2840 (class 0 OID 26466)
-- Dependencies: 197
-- Data for Name: positions; Type: TABLE DATA; Schema: public; Owner: sunman
--

INSERT INTO public.positions (id, name, salary) VALUES (1, 'Restaurateur', 100000.00);
INSERT INTO public.positions (id, name, salary) VALUES (2, 'Waiter', 35000.00);
INSERT INTO public.positions (id, name, salary) VALUES (3, 'Chef', 60000.00);


--
-- TOC entry 2841 (class 0 OID 26486)
-- Dependencies: 198
-- Data for Name: workers; Type: TABLE DATA; Schema: public; Owner: sunman
--

INSERT INTO public.workers (id, full_name, position_id) VALUES (1, 'Terentiev Michal Palych', 1);
INSERT INTO public.workers (id, full_name, position_id) VALUES (2, 'Ostrezov Nikita', 3);
INSERT INTO public.workers (id, full_name, position_id) VALUES (3, 'Ivanov Bogdan', 2);


--
-- TOC entry 2705 (class 2606 OID 26464)
-- Name: dishes menu_dish_key; Type: CONSTRAINT; Schema: public; Owner: sunman
--

ALTER TABLE ONLY public.dishes
    ADD CONSTRAINT menu_dish_key UNIQUE (name);


--
-- TOC entry 2707 (class 2606 OID 26462)
-- Name: dishes menu_pkey; Type: CONSTRAINT; Schema: public; Owner: sunman
--

ALTER TABLE ONLY public.dishes
    ADD CONSTRAINT menu_pkey PRIMARY KEY (id);


--
-- TOC entry 2713 (class 2606 OID 26552)
-- Name: orders orders_pkey; Type: CONSTRAINT; Schema: public; Owner: sunman
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_pkey PRIMARY KEY (id);


--
-- TOC entry 2709 (class 2606 OID 26474)
-- Name: positions positions_pkey; Type: CONSTRAINT; Schema: public; Owner: sunman
--

ALTER TABLE ONLY public.positions
    ADD CONSTRAINT positions_pkey PRIMARY KEY (id);


--
-- TOC entry 2711 (class 2606 OID 26493)
-- Name: workers workers_pkey; Type: CONSTRAINT; Schema: public; Owner: sunman
--

ALTER TABLE ONLY public.workers
    ADD CONSTRAINT workers_pkey PRIMARY KEY (id);


--
-- TOC entry 2717 (class 2606 OID 26553)
-- Name: orders orders_chef_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: sunman
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_chef_id_fkey FOREIGN KEY (chef_id) REFERENCES public.workers(id) MATCH FULL ON UPDATE RESTRICT ON DELETE RESTRICT;


--
-- TOC entry 2715 (class 2606 OID 26504)
-- Name: orders orders_dish_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: sunman
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_dish_id_fkey FOREIGN KEY (dish_id) REFERENCES public.dishes(id) MATCH FULL ON UPDATE RESTRICT ON DELETE RESTRICT;


--
-- TOC entry 2716 (class 2606 OID 26509)
-- Name: orders orders_waiter_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: sunman
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_waiter_id_fkey FOREIGN KEY (waiter_id) REFERENCES public.workers(id) MATCH FULL ON UPDATE RESTRICT ON DELETE RESTRICT;


--
-- TOC entry 2714 (class 2606 OID 26496)
-- Name: workers workers_position_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: sunman
--

ALTER TABLE ONLY public.workers
    ADD CONSTRAINT workers_position_id_fkey FOREIGN KEY (position_id) REFERENCES public.positions(id) MATCH FULL ON UPDATE RESTRICT ON DELETE RESTRICT;


--
-- TOC entry 2848 (class 0 OID 0)
-- Dependencies: 3
-- Name: SCHEMA public; Type: ACL; Schema: -; Owner: postgres
--

GRANT ALL ON SCHEMA public TO admin WITH GRANT OPTION;


--
-- TOC entry 2849 (class 0 OID 0)
-- Dependencies: 196
-- Name: TABLE dishes; Type: ACL; Schema: public; Owner: sunman
--

GRANT ALL ON TABLE public.dishes TO admin WITH GRANT OPTION;


--
-- TOC entry 2850 (class 0 OID 0)
-- Dependencies: 199
-- Name: TABLE orders; Type: ACL; Schema: public; Owner: sunman
--

GRANT ALL ON TABLE public.orders TO admin WITH GRANT OPTION;


--
-- TOC entry 2851 (class 0 OID 0)
-- Dependencies: 197
-- Name: TABLE positions; Type: ACL; Schema: public; Owner: sunman
--

GRANT ALL ON TABLE public.positions TO admin WITH GRANT OPTION;


--
-- TOC entry 2852 (class 0 OID 0)
-- Dependencies: 198
-- Name: TABLE workers; Type: ACL; Schema: public; Owner: sunman
--

GRANT ALL ON TABLE public.workers TO admin WITH GRANT OPTION;


-- Completed on 2022-03-17 15:09:31

--
-- PostgreSQL database dump complete
--

