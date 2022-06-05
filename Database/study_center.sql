--
-- PostgreSQL database dump
--

-- Dumped from database version 11.13
-- Dumped by pg_dump version 11.13

-- Started on 2022-06-05 19:07:03

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

DROP DATABASE study_center;
--
-- TOC entry 2897 (class 1262 OID 34844)
-- Name: study_center; Type: DATABASE; Schema: -; Owner: -
--

CREATE DATABASE study_center WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Russian_Russia.1251' LC_CTYPE = 'Russian_Russia.1251';


\connect study_center

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

--
-- TOC entry 241 (class 1255 OID 35227)
-- Name: delete_completed_course(integer); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.delete_completed_course(_id integer) RETURNS void
    LANGUAGE sql
    AS $$
DELETE FROM Training_Info WHERE id = _id; 
$$;


--
-- TOC entry 230 (class 1255 OID 35131)
-- Name: delete_course(integer); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.delete_course(_id integer) RETURNS void
    LANGUAGE sql
    AS $$
DELETE FROM Courses WHERE id = _id;
$$;


--
-- TOC entry 223 (class 1255 OID 35137)
-- Name: delete_department(integer); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.delete_department(_id integer) RETURNS void
    LANGUAGE sql
    AS $$
DELETE FROM Departments WHERE id = _id;
$$;


--
-- TOC entry 229 (class 1255 OID 35135)
-- Name: delete_employee(integer); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.delete_employee(_id integer) RETURNS void
    LANGUAGE sql
    AS $$
DELETE FROM Employee WHERE id = _id;
$$;


--
-- TOC entry 222 (class 1255 OID 35133)
-- Name: delete_position(integer); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.delete_position(_id integer) RETURNS void
    LANGUAGE sql
    AS $$
DELETE FROM Positions WHERE id = _id;
$$;


--
-- TOC entry 231 (class 1255 OID 35223)
-- Name: get_completed_courses(); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.get_completed_courses() RETURNS TABLE(id integer, employee_id integer, employee_surname character varying, employee_name character varying, employee_position character varying, department character varying, course_id integer, course_name character varying, course_duration integer, course_description character varying, completion_date date)
    LANGUAGE sql IMMUTABLE LEAKPROOF
    AS $$
SELECT
ti.id AS id,
e.id  AS employee_id,
e.surname  AS employee_surname,
e.name  AS employee_name,
p.name  AS employee_position,
d.name   AS employee_department,
c.id AS course_id,
c.name AS course_name,
c.duration AS course_duration,
c.description AS course_description,
ti.completion_date AS completion_date
FROM training_info AS ti
INNER JOIN Employee AS e ON ti.employee_id = e.id
INNER JOIN Courses AS c ON ti.course_id = c.id
INNER JOIN Positions AS p ON e.position_id = p.id
INNER JOIN Departments AS d ON e.department_id = d.id
ORDER BY ti.completion_date DESC;
$$;


--
-- TOC entry 233 (class 1255 OID 35119)
-- Name: get_courses(); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.get_courses() RETURNS TABLE(id integer, name character varying, duration integer, department character varying, description character varying)
    LANGUAGE sql IMMUTABLE LEAKPROOF
    AS $$
SELECT
c.id AS id,
c.name AS name,
c.duration AS duration,
d.name AS department,
c.description AS description
FROM Courses AS c INNER JOIN Departments AS d ON c.department_id = d.id
ORDER BY c.id ASC;
$$;


--
-- TOC entry 220 (class 1255 OID 35107)
-- Name: get_departments_list(); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.get_departments_list() RETURNS TABLE(id integer, name character varying)
    LANGUAGE sql IMMUTABLE LEAKPROOF
    AS $$
SELECT * FROM departments ORDER BY id ASC;
$$;


--
-- TOC entry 235 (class 1255 OID 35113)
-- Name: get_employee(); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.get_employee() RETURNS TABLE(id integer, surname character varying, name character varying, job character varying, department character varying, employment_date date)
    LANGUAGE sql IMMUTABLE LEAKPROOF
    AS $$
SELECT
e.id AS id,
e.surname AS surname,
e.name AS name,
p.name AS position,
d.name AS department,
e.employment_date AS employment_date
FROM Employee AS e
INNER JOIN Positions AS p ON e.position_id = p.id
INNER JOIN Departments AS d ON e.department_id = d.id
ORDER BY e.id ASC;
$$;


--
-- TOC entry 232 (class 1255 OID 35141)
-- Name: get_not_trained_employee(); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.get_not_trained_employee() RETURNS TABLE(id integer, surname character varying, name character varying, job character varying, department character varying, employment_date date)
    LANGUAGE sql IMMUTABLE LEAKPROOF
    AS $$
WITH ti AS (
SELECT
employee_id AS employee_id,
MAX(completion_date) AS completion_date
FROM training_info AS ti
GROUP BY employee_id
)
SELECT
e.id AS id,
e.surname AS surname,
e.name AS name,
p.name AS position,
d.name AS department,
e.employment_date AS employment_date
FROM Employee AS e
INNER JOIN Positions AS p ON e.position_id = p.id
INNER JOIN Departments AS d ON e.department_id = d.id
INNER JOIN ti ON ti.employee_id = e.id
WHERE (CURRENT_DATE - ti.completion_date) > 365
ORDER BY e.id ASC;
$$;


--
-- TOC entry 219 (class 1255 OID 35106)
-- Name: get_positions_list(); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.get_positions_list() RETURNS TABLE(id integer, name character varying)
    LANGUAGE sql IMMUTABLE LEAKPROOF
    AS $$
SELECT * FROM positions ORDER BY id ASC;
$$;


--
-- TOC entry 236 (class 1255 OID 35138)
-- Name: get_trained_employee(interval); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.get_trained_employee(period interval) RETURNS TABLE(id integer, surname character varying, name character varying, job character varying, department character varying, employment_date date)
    LANGUAGE sql IMMUTABLE LEAKPROOF
    AS $$
SELECT
e.id AS id,
e.surname AS surname,
e.name AS name,
p.name AS position,
d.name AS department,
e.employment_date AS employment_date
FROM Employee AS e
INNER JOIN Positions AS p ON e.position_id = p.id
INNER JOIN Departments AS d ON e.department_id = d.id
INNER JOIN Training_Info AS ti ON ti.employee_id = e.id
WHERE ti.completion_date BETWEEN CURRENT_DATE - period AND CURRENT_DATE
ORDER BY e.id ASC;
$$;


--
-- TOC entry 239 (class 1255 OID 35225)
-- Name: get_trained_employee_by_department(character varying); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.get_trained_employee_by_department(department character varying) RETURNS TABLE(id integer, employee_id integer, employee_surname character varying, employee_name character varying, employee_position character varying, course_id integer, course_name character varying, course_duration integer, course_description character varying, completion_date date)
    LANGUAGE sql IMMUTABLE LEAKPROOF
    AS $$
SELECT
ti.id AS id,
e.id  AS employee_id,
e.surname  AS employee_surname,
e.name AS employee_name,
p.name  AS employee_position,
c.id AS course_id,
c.name AS course_name,
c.duration AS course_duration,
c.description AS course_description,
ti.completion_date AS completion_date
FROM training_info AS ti
INNER JOIN Employee  AS e ON ti.employee_id = e.id
INNER JOIN Courses  AS c ON ti.course_id = c.id
INNER JOIN Positions  AS p ON e.position_id = p.id
INNER JOIN Departments AS d ON e.department_id = d.id
WHERE (d.name = department) AND (ti.completion_date < CURRENT_DATE)
ORDER BY e.id ASC;
$$;


--
-- TOC entry 224 (class 1255 OID 35136)
-- Name: insert_completed_course(integer, integer, date); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.insert_completed_course(_employee_id integer, _course_id integer, _completion_date date) RETURNS void
    LANGUAGE sql
    AS $$
INSERT INTO Training_Info(employee_id, course_id, completion_date) VALUES
(_employee_id, _course_id, _completion_date);
$$;


--
-- TOC entry 234 (class 1255 OID 35118)
-- Name: insert_course(character varying, integer, character varying, character varying); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.insert_course(_name character varying, _duration integer, _department character varying, _description character varying) RETURNS void
    LANGUAGE sql
    AS $$
WITH dep_id AS (SELECT id FROM Departments WHERE name = _department)
INSERT INTO Courses(name, duration, department_id, description) VALUES
(_name, _duration, (SELECT id FROM dep_id), _description);
$$;


--
-- TOC entry 206 (class 1255 OID 35122)
-- Name: insert_department(character varying); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.insert_department(_department character varying) RETURNS void
    LANGUAGE sql
    AS $$
INSERT INTO Departments(name) VALUES (_department);
$$;


--
-- TOC entry 237 (class 1255 OID 35117)
-- Name: insert_employee(character varying, character varying, character varying, character varying, date); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.insert_employee(_surname character varying, _name character varying, _job character varying, _department character varying, _employment_date date) RETURNS void
    LANGUAGE sql
    AS $$
WITH
job_id AS (SELECT id FROM Positions WHERE name = _job),
dep_id AS (SELECT id FROM Departments WHERE name = _department)
INSERT INTO Employee(surname, name, position_id, department_id, employment_date) VALUES
(_surname, _name, (SELECT id FROM job_id), (SELECT id FROM dep_id), _employment_date);
$$;


--
-- TOC entry 238 (class 1255 OID 35121)
-- Name: insert_position(character varying); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.insert_position(_position character varying) RETURNS void
    LANGUAGE sql
    AS $$
INSERT INTO Positions(name) VALUES (_position);
$$;


--
-- TOC entry 221 (class 1255 OID 35126)
-- Name: update_complete_course(integer, integer, date); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.update_complete_course(_employee_id integer, _course_id integer, _completion_date date) RETURNS void
    LANGUAGE sql
    AS $$
UPDATE Training_Info SET completion_date = _completion_date
WHERE (employee_id = _employee_id) AND (course_id = _course_id)
$$;


--
-- TOC entry 240 (class 1255 OID 35226)
-- Name: update_completed_course(integer, integer, integer, date); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.update_completed_course(_id integer, _employee_id integer, _course_id integer, _completion_date date) RETURNS void
    LANGUAGE sql
    AS $$
UPDATE Training_Info SET completion_date = _completion_date
WHERE id = _id;
$$;


--
-- TOC entry 226 (class 1255 OID 35124)
-- Name: update_course(integer, character varying, integer, character varying, character varying); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.update_course(_id integer, _name character varying, _duration integer, _department character varying, _description character varying) RETURNS void
    LANGUAGE sql
    AS $$
WITH dep_id AS (SELECT id FROM Departments WHERE name = _department)
UPDATE Courses SET
name = _name, duration = _duration,
department_id = (SELECT id FROM dep_id), description = _description
WHERE id = _id;
$$;


--
-- TOC entry 228 (class 1255 OID 35129)
-- Name: update_department(integer, character varying); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.update_department(_id integer, _department character varying) RETURNS void
    LANGUAGE sql
    AS $$
UPDATE Departments SET name = _department WHERE id = _id;
$$;


--
-- TOC entry 225 (class 1255 OID 35123)
-- Name: update_employee(integer, character varying, character varying, character varying, character varying, date); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.update_employee(_id integer, _surname character varying, _name character varying, _job character varying, _department character varying, _employment_date date) RETURNS void
    LANGUAGE sql
    AS $$
WITH
job_id AS (SELECT id FROM Positions WHERE name = _job),
dep_id AS (SELECT id FROM Departments WHERE name = _department)
UPDATE Employee SET 
surname = _surname, name = _name,
position_id = (SELECT id FROM job_id), department_id = (SELECT id FROM dep_id),
employment_date = _employment_date
WHERE id = _id;
$$;


--
-- TOC entry 227 (class 1255 OID 35128)
-- Name: update_position(integer, character varying); Type: FUNCTION; Schema: public; Owner: -
--

CREATE FUNCTION public.update_position(_id integer, _position character varying) RETURNS void
    LANGUAGE sql
    AS $$
UPDATE Positions SET name = _position WHERE id = _id;
$$;


SET default_with_oids = false;

--
-- TOC entry 203 (class 1259 OID 35189)
-- Name: courses; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.courses (
    id integer NOT NULL,
    name character varying(256) NOT NULL,
    duration integer NOT NULL,
    department_id integer NOT NULL,
    description character varying(1024),
    CONSTRAINT courses_duration_check CHECK ((duration > 0))
);


--
-- TOC entry 202 (class 1259 OID 35187)
-- Name: courses_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.courses_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 2898 (class 0 OID 0)
-- Dependencies: 202
-- Name: courses_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.courses_id_seq OWNED BY public.courses.id;


--
-- TOC entry 199 (class 1259 OID 35157)
-- Name: departments; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.departments (
    id integer NOT NULL,
    name character varying(256) NOT NULL
);


--
-- TOC entry 198 (class 1259 OID 35155)
-- Name: departments_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.departments_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 2899 (class 0 OID 0)
-- Dependencies: 198
-- Name: departments_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.departments_id_seq OWNED BY public.departments.id;


--
-- TOC entry 201 (class 1259 OID 35167)
-- Name: employee; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.employee (
    id integer NOT NULL,
    surname character varying(256) NOT NULL,
    name character varying(256) NOT NULL,
    position_id integer NOT NULL,
    department_id integer NOT NULL,
    employment_date date DEFAULT CURRENT_DATE NOT NULL
);


--
-- TOC entry 200 (class 1259 OID 35165)
-- Name: employee_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.employee_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 2900 (class 0 OID 0)
-- Dependencies: 200
-- Name: employee_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.employee_id_seq OWNED BY public.employee.id;


--
-- TOC entry 197 (class 1259 OID 35147)
-- Name: positions; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.positions (
    id integer NOT NULL,
    name character varying(256) NOT NULL
);


--
-- TOC entry 196 (class 1259 OID 35145)
-- Name: positions_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.positions_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 2901 (class 0 OID 0)
-- Dependencies: 196
-- Name: positions_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.positions_id_seq OWNED BY public.positions.id;


--
-- TOC entry 205 (class 1259 OID 35206)
-- Name: training_info; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.training_info (
    id integer NOT NULL,
    employee_id integer NOT NULL,
    course_id integer NOT NULL,
    completion_date date NOT NULL
);


--
-- TOC entry 204 (class 1259 OID 35204)
-- Name: training_info_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.training_info_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- TOC entry 2902 (class 0 OID 0)
-- Dependencies: 204
-- Name: training_info_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.training_info_id_seq OWNED BY public.training_info.id;


--
-- TOC entry 2739 (class 2604 OID 35192)
-- Name: courses id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.courses ALTER COLUMN id SET DEFAULT nextval('public.courses_id_seq'::regclass);


--
-- TOC entry 2736 (class 2604 OID 35160)
-- Name: departments id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.departments ALTER COLUMN id SET DEFAULT nextval('public.departments_id_seq'::regclass);


--
-- TOC entry 2737 (class 2604 OID 35170)
-- Name: employee id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.employee ALTER COLUMN id SET DEFAULT nextval('public.employee_id_seq'::regclass);


--
-- TOC entry 2735 (class 2604 OID 35150)
-- Name: positions id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.positions ALTER COLUMN id SET DEFAULT nextval('public.positions_id_seq'::regclass);


--
-- TOC entry 2741 (class 2604 OID 35209)
-- Name: training_info id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.training_info ALTER COLUMN id SET DEFAULT nextval('public.training_info_id_seq'::regclass);


--
-- TOC entry 2889 (class 0 OID 35189)
-- Dependencies: 203
-- Data for Name: courses; Type: TABLE DATA; Schema: public; Owner: -
--

INSERT INTO public.courses (id, name, duration, department_id, description) VALUES (4, 'React за 21 день', 504, 4, 'Это нереально');
INSERT INTO public.courses (id, name, duration, department_id, description) VALUES (3, 'Паттерны проектирования', 240, 3, 'Паттерны всякие разные');
INSERT INTO public.courses (id, name, duration, department_id, description) VALUES (2, 'Введение в Swift', 260, 1, 'Для IOS самое то');
INSERT INTO public.courses (id, name, duration, department_id, description) VALUES (1, 'Погружаемся в Kotlin', 250, 1, 'Для Android самое то');
INSERT INTO public.courses (id, name, duration, department_id, description) VALUES (5, 'Введение в мобильную разработку', 450, 1, 'Вполне реально');


--
-- TOC entry 2885 (class 0 OID 35157)
-- Dependencies: 199
-- Data for Name: departments; Type: TABLE DATA; Schema: public; Owner: -
--

INSERT INTO public.departments (id, name) VALUES (1, 'Отдел мобильной разработки');
INSERT INTO public.departments (id, name) VALUES (3, 'Отдел Backend-разработки');
INSERT INTO public.departments (id, name) VALUES (4, 'Отдел Frontend-разработки');


--
-- TOC entry 2887 (class 0 OID 35167)
-- Dependencies: 201
-- Data for Name: employee; Type: TABLE DATA; Schema: public; Owner: -
--

INSERT INTO public.employee (id, surname, name, position_id, department_id, employment_date) VALUES (2, 'Нужнов', 'Андрей', 1, 1, '2022-05-01');
INSERT INTO public.employee (id, surname, name, position_id, department_id, employment_date) VALUES (5, 'Бахаров', 'Малик', 3, 3, '2022-04-16');
INSERT INTO public.employee (id, surname, name, position_id, department_id, employment_date) VALUES (6, 'Острецов', 'Никита', 5, 4, '2022-04-01');
INSERT INTO public.employee (id, surname, name, position_id, department_id, employment_date) VALUES (3, 'Васильев', 'Петр', 2, 1, '2021-04-15');
INSERT INTO public.employee (id, surname, name, position_id, department_id, employment_date) VALUES (7, 'Петров', 'Василий', 1, 1, '2022-05-01');


--
-- TOC entry 2883 (class 0 OID 35147)
-- Dependencies: 197
-- Data for Name: positions; Type: TABLE DATA; Schema: public; Owner: -
--

INSERT INTO public.positions (id, name) VALUES (3, 'Java разработчик');
INSERT INTO public.positions (id, name) VALUES (5, 'React разработчик');
INSERT INTO public.positions (id, name) VALUES (1, 'Android разработчик');
INSERT INTO public.positions (id, name) VALUES (2, 'IOS разработчик');
INSERT INTO public.positions (id, name) VALUES (7, 'Angular разработчик');


--
-- TOC entry 2891 (class 0 OID 35206)
-- Dependencies: 205
-- Data for Name: training_info; Type: TABLE DATA; Schema: public; Owner: -
--

INSERT INTO public.training_info (id, employee_id, course_id, completion_date) VALUES (1, 2, 1, '2022-05-10');
INSERT INTO public.training_info (id, employee_id, course_id, completion_date) VALUES (2, 6, 4, '2022-04-01');
INSERT INTO public.training_info (id, employee_id, course_id, completion_date) VALUES (3, 3, 2, '2022-05-01');
INSERT INTO public.training_info (id, employee_id, course_id, completion_date) VALUES (4, 7, 5, '2022-04-10');
INSERT INTO public.training_info (id, employee_id, course_id, completion_date) VALUES (5, 5, 3, '2022-04-10');


--
-- TOC entry 2903 (class 0 OID 0)
-- Dependencies: 202
-- Name: courses_id_seq; Type: SEQUENCE SET; Schema: public; Owner: -
--

SELECT pg_catalog.setval('public.courses_id_seq', 5, true);


--
-- TOC entry 2904 (class 0 OID 0)
-- Dependencies: 198
-- Name: departments_id_seq; Type: SEQUENCE SET; Schema: public; Owner: -
--

SELECT pg_catalog.setval('public.departments_id_seq', 8, true);


--
-- TOC entry 2905 (class 0 OID 0)
-- Dependencies: 200
-- Name: employee_id_seq; Type: SEQUENCE SET; Schema: public; Owner: -
--

SELECT pg_catalog.setval('public.employee_id_seq', 8, true);


--
-- TOC entry 2906 (class 0 OID 0)
-- Dependencies: 196
-- Name: positions_id_seq; Type: SEQUENCE SET; Schema: public; Owner: -
--

SELECT pg_catalog.setval('public.positions_id_seq', 7, true);


--
-- TOC entry 2907 (class 0 OID 0)
-- Dependencies: 204
-- Name: training_info_id_seq; Type: SEQUENCE SET; Schema: public; Owner: -
--

SELECT pg_catalog.setval('public.training_info_id_seq', 5, true);


--
-- TOC entry 2753 (class 2606 OID 35198)
-- Name: courses courses_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.courses
    ADD CONSTRAINT courses_pkey PRIMARY KEY (id);


--
-- TOC entry 2747 (class 2606 OID 35164)
-- Name: departments departments_name_key; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.departments
    ADD CONSTRAINT departments_name_key UNIQUE (name);


--
-- TOC entry 2749 (class 2606 OID 35162)
-- Name: departments departments_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.departments
    ADD CONSTRAINT departments_pkey PRIMARY KEY (id);


--
-- TOC entry 2751 (class 2606 OID 35176)
-- Name: employee employee_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.employee
    ADD CONSTRAINT employee_pkey PRIMARY KEY (id);


--
-- TOC entry 2743 (class 2606 OID 35154)
-- Name: positions positions_name_key; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.positions
    ADD CONSTRAINT positions_name_key UNIQUE (name);


--
-- TOC entry 2745 (class 2606 OID 35152)
-- Name: positions positions_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.positions
    ADD CONSTRAINT positions_pkey PRIMARY KEY (id);


--
-- TOC entry 2755 (class 2606 OID 35211)
-- Name: training_info training_info_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.training_info
    ADD CONSTRAINT training_info_pkey PRIMARY KEY (id);


--
-- TOC entry 2758 (class 2606 OID 35199)
-- Name: courses courses_department_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.courses
    ADD CONSTRAINT courses_department_id_fkey FOREIGN KEY (department_id) REFERENCES public.departments(id);


--
-- TOC entry 2757 (class 2606 OID 35182)
-- Name: employee employee_department_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.employee
    ADD CONSTRAINT employee_department_id_fkey FOREIGN KEY (department_id) REFERENCES public.departments(id) MATCH FULL;


--
-- TOC entry 2756 (class 2606 OID 35177)
-- Name: employee employee_position_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.employee
    ADD CONSTRAINT employee_position_id_fkey FOREIGN KEY (position_id) REFERENCES public.positions(id) MATCH FULL;


--
-- TOC entry 2760 (class 2606 OID 35217)
-- Name: training_info training_info_course_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.training_info
    ADD CONSTRAINT training_info_course_id_fkey FOREIGN KEY (course_id) REFERENCES public.courses(id) MATCH FULL;


--
-- TOC entry 2759 (class 2606 OID 35212)
-- Name: training_info training_info_employee_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.training_info
    ADD CONSTRAINT training_info_employee_id_fkey FOREIGN KEY (employee_id) REFERENCES public.employee(id) MATCH FULL;


-- Completed on 2022-06-05 19:07:03

--
-- PostgreSQL database dump complete
--

