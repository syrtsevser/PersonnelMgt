--
-- PostgreSQL database dump
--

-- Dumped from database version 14.3
-- Dumped by pg_dump version 14.3

-- Started on 2022-06-05 14:29:02

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
-- TOC entry 3426 (class 1262 OID 16524)
-- Name: personnel_mgt; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE personnel_mgt WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';


ALTER DATABASE personnel_mgt OWNER TO postgres;

\connect personnel_mgt

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
-- TOC entry 3427 (class 0 OID 0)
-- Dependencies: 3426
-- Name: DATABASE personnel_mgt; Type: COMMENT; Schema: -; Owner: postgres
--

COMMENT ON DATABASE personnel_mgt IS 'ИС "Сотрудники компании"';


SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 226 (class 1259 OID 16644)
-- Name: access; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.access (
    id_access integer NOT NULL,
    description text
);


ALTER TABLE public.access OWNER TO postgres;

--
-- TOC entry 228 (class 1259 OID 16652)
-- Name: access_grant; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.access_grant (
    id_grant integer NOT NULL,
    id_person integer NOT NULL,
    id_access integer NOT NULL
);


ALTER TABLE public.access_grant OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 16651)
-- Name: access_grant_id_grant_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.access_grant ALTER COLUMN id_grant ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.access_grant_id_grant_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 225 (class 1259 OID 16643)
-- Name: access_id_access_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.access ALTER COLUMN id_access ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.access_id_access_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 224 (class 1259 OID 16626)
-- Name: certificates; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.certificates (
    id_cert integer NOT NULL,
    id_person integer NOT NULL,
    description text,
    date_valid date
);


ALTER TABLE public.certificates OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 16625)
-- Name: certificates_id_cert_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.certificates ALTER COLUMN id_cert ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.certificates_id_cert_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 214 (class 1259 OID 16550)
-- Name: departments; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.departments (
    id_dept integer NOT NULL,
    id_org integer,
    name text NOT NULL
);


ALTER TABLE public.departments OWNER TO postgres;

--
-- TOC entry 213 (class 1259 OID 16549)
-- Name: departments_id_dept_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.departments ALTER COLUMN id_dept ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.departments_id_dept_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 212 (class 1259 OID 16541)
-- Name: employees; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.employees (
    id_employee integer NOT NULL,
    id_person integer,
    date_hired date,
    date_dismissed date,
    id_dept integer,
    "position" text,
    id_room integer,
    hours_week smallint
);


ALTER TABLE public.employees OWNER TO postgres;

--
-- TOC entry 211 (class 1259 OID 16540)
-- Name: employees_id_employee_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.employees ALTER COLUMN id_employee ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.employees_id_employee_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 230 (class 1259 OID 16668)
-- Name: hardware; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.hardware (
    id_hw integer NOT NULL,
    id_org integer NOT NULL,
    id_room integer,
    category text,
    pc_name text,
    name text
);


ALTER TABLE public.hardware OWNER TO postgres;

--
-- TOC entry 229 (class 1259 OID 16667)
-- Name: hardware_id_hw_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.hardware ALTER COLUMN id_hw ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.hardware_id_hw_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 232 (class 1259 OID 16687)
-- Name: hardware_lease; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.hardware_lease (
    id_lease integer NOT NULL,
    id_hw integer NOT NULL,
    id_person integer,
    date_given date,
    date_returned date
);


ALTER TABLE public.hardware_lease OWNER TO postgres;

--
-- TOC entry 231 (class 1259 OID 16686)
-- Name: hardware_lease_id_lease_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.hardware_lease ALTER COLUMN id_lease ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.hardware_lease_id_lease_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 220 (class 1259 OID 16599)
-- Name: keys; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.keys (
    id_key integer NOT NULL,
    id_room integer NOT NULL
);


ALTER TABLE public.keys OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 16598)
-- Name: keys_id_key_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.keys ALTER COLUMN id_key ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.keys_id_key_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 222 (class 1259 OID 16610)
-- Name: keys_lease; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.keys_lease (
    id_lease integer NOT NULL,
    id_key integer NOT NULL,
    id_person integer NOT NULL,
    date_given date,
    date_returned date
);


ALTER TABLE public.keys_lease OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 16609)
-- Name: keys_lease_id_lease_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.keys_lease ALTER COLUMN id_lease ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.keys_lease_id_lease_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 216 (class 1259 OID 16558)
-- Name: orgs; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.orgs (
    id_org integer NOT NULL,
    name text NOT NULL,
    region text,
    address text,
    name_full text
);


ALTER TABLE public.orgs OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 16557)
-- Name: orgs_id_org_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.orgs ALTER COLUMN id_org ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.orgs_id_org_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 209 (class 1259 OID 16525)
-- Name: people; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.people (
    id_person integer NOT NULL,
    name_last text,
    name_first text,
    name_middle text,
    date_birth date,
    contact_phone text,
    contact_email text,
    contact_other text,
    comment text
);


ALTER TABLE public.people OWNER TO postgres;

--
-- TOC entry 210 (class 1259 OID 16532)
-- Name: people_id_people_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.people ALTER COLUMN id_person ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.people_id_people_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 218 (class 1259 OID 16566)
-- Name: rooms; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.rooms (
    id_room integer NOT NULL,
    id_org integer NOT NULL,
    number text,
    max_workplaces integer NOT NULL
);


ALTER TABLE public.rooms OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 16565)
-- Name: rooms_id_room_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.rooms ALTER COLUMN id_room ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.rooms_id_room_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 3414 (class 0 OID 16644)
-- Dependencies: 226
-- Data for Name: access; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3416 (class 0 OID 16652)
-- Dependencies: 228
-- Data for Name: access_grant; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3412 (class 0 OID 16626)
-- Dependencies: 224
-- Data for Name: certificates; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3402 (class 0 OID 16550)
-- Dependencies: 214
-- Data for Name: departments; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.departments (id_dept, id_org, name) OVERRIDING SYSTEM VALUE VALUES (1, 1, 'Департамент CRM');
INSERT INTO public.departments (id_dept, id_org, name) OVERRIDING SYSTEM VALUE VALUES (5, 1, 'Департамент GCRM');
INSERT INTO public.departments (id_dept, id_org, name) OVERRIDING SYSTEM VALUE VALUES (9, 1, 'Департамент SAP');
INSERT INTO public.departments (id_dept, id_org, name) OVERRIDING SYSTEM VALUE VALUES (10, 1, 'Департамент SRM');


--
-- TOC entry 3400 (class 0 OID 16541)
-- Dependencies: 212
-- Data for Name: employees; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (12, 20, '2014-08-04', NULL, 9, 'Веб-разработчик', 6, 40);
INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (15, 22, '2021-07-05', NULL, 1, 'Разработчик', 1, 40);
INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (1, 1, '2018-09-04', '2022-06-02', 1, 'Менеджер', 1, 12);
INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (13, 21, '2017-06-01', NULL, 5, 'Консультант', 6, 40);
INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (10, 18, '2021-05-01', NULL, 5, 'Аналитик', 6, 40);
INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (9, 17, '2019-11-06', NULL, 1, 'Разработчик', 1, 40);
INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (14, 14, '2019-04-29', NULL, 5, 'Оператор тех. поддержки', 6, 36);
INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (11, 19, '2022-02-20', NULL, 9, 'Помощник', 6, 32);
INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (8, 16, '2021-02-27', NULL, 1, 'Разработчик', 1, 40);
INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (17, 24, '2021-06-20', '2021-07-21', 1, 'Стажёр', 1, 15);
INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (16, 23, '2021-02-01', '2021-10-03', 1, 'Программист', 1, 40);
INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (3, 1, '2014-05-24', NULL, 1, 'Помощник', NULL, 0);
INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (19, 26, '2019-05-29', '2021-01-29', 1, 'Разработчик', 6, 40);
INSERT INTO public.employees (id_employee, id_person, date_hired, date_dismissed, id_dept, "position", id_room, hours_week) OVERRIDING SYSTEM VALUE VALUES (18, 25, '2020-02-19', '2021-10-29', 1, 'Помощник', 1, 40);


--
-- TOC entry 3418 (class 0 OID 16668)
-- Dependencies: 230
-- Data for Name: hardware; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3420 (class 0 OID 16687)
-- Dependencies: 232
-- Data for Name: hardware_lease; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3408 (class 0 OID 16599)
-- Dependencies: 220
-- Data for Name: keys; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3410 (class 0 OID 16610)
-- Dependencies: 222
-- Data for Name: keys_lease; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- TOC entry 3404 (class 0 OID 16558)
-- Dependencies: 216
-- Data for Name: orgs; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.orgs (id_org, name, region, address, name_full) OVERRIDING SYSTEM VALUE VALUES (1, 'Организация 1 (Киров)', 'Кировская область', NULL, NULL);


--
-- TOC entry 3397 (class 0 OID 16525)
-- Dependencies: 209
-- Data for Name: people; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.people (id_person, name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment) OVERRIDING SYSTEM VALUE VALUES (20, 'Барбарина', 'Людмила', 'Николаевна', '1987-07-11', '+79401231122', NULL, NULL, NULL);
INSERT INTO public.people (id_person, name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment) OVERRIDING SYSTEM VALUE VALUES (22, 'Бакулева', 'Ксения', 'Леонидовна', '1991-01-19', '+79112223344', NULL, NULL, NULL);
INSERT INTO public.people (id_person, name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment) OVERRIDING SYSTEM VALUE VALUES (21, 'Шишкин', 'Григорий', 'Игоревич', '1986-12-16', '+79331114455', NULL, NULL, NULL);
INSERT INTO public.people (id_person, name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment) OVERRIDING SYSTEM VALUE VALUES (18, 'Кривошеин', 'Валентин', 'Александрович', '1975-07-15', '+79227778899', NULL, NULL, NULL);
INSERT INTO public.people (id_person, name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment) OVERRIDING SYSTEM VALUE VALUES (17, 'Легкова', 'Мария', 'Игоревна', '1991-11-22', '+79145556677', NULL, NULL, NULL);
INSERT INTO public.people (id_person, name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment) OVERRIDING SYSTEM VALUE VALUES (14, 'Любимцев', 'Владислав', 'Ярославович', '1994-10-18', '+79118887766', NULL, '<телеграм_ссылка>', NULL);
INSERT INTO public.people (id_person, name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment) OVERRIDING SYSTEM VALUE VALUES (19, 'Сысолятин', 'Тимур', 'Дмитриевич', '1996-08-24', '+79601112233', NULL, NULL, NULL);
INSERT INTO public.people (id_person, name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment) OVERRIDING SYSTEM VALUE VALUES (16, 'Чернядев', 'Дмитрий', 'Александрович', '1983-02-01', '+79221112233', NULL, NULL, NULL);
INSERT INTO public.people (id_person, name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment) OVERRIDING SYSTEM VALUE VALUES (24, 'Беляев', 'Олег', 'Серафимович', '1998-02-17', '+71111111111', NULL, NULL, NULL);
INSERT INTO public.people (id_person, name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment) OVERRIDING SYSTEM VALUE VALUES (23, 'Петрович', 'Сергей', 'Дмитриевич', '1984-03-04', '+79121111111', NULL, NULL, NULL);
INSERT INTO public.people (id_person, name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment) OVERRIDING SYSTEM VALUE VALUES (1, 'Петров', 'Аркадий', 'Борисович', '1979-06-03', '+79221112233', 'a.petrov@mail.com', NULL, NULL);
INSERT INTO public.people (id_person, name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment) OVERRIDING SYSTEM VALUE VALUES (26, 'Башмулев', 'Ярослав', 'Геннадьевич', '1990-09-10', '+79625554433', NULL, NULL, NULL);
INSERT INTO public.people (id_person, name_last, name_first, name_middle, date_birth, contact_phone, contact_email, contact_other, comment) OVERRIDING SYSTEM VALUE VALUES (25, 'Малых', 'Артур', 'Антонович', '1973-08-26', NULL, NULL, NULL, NULL);


--
-- TOC entry 3406 (class 0 OID 16566)
-- Dependencies: 218
-- Data for Name: rooms; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.rooms (id_room, id_org, number, max_workplaces) OVERRIDING SYSTEM VALUE VALUES (1, 1, '4-205', 7);
INSERT INTO public.rooms (id_room, id_org, number, max_workplaces) OVERRIDING SYSTEM VALUE VALUES (6, 1, '4-207', 12);


--
-- TOC entry 3430 (class 0 OID 0)
-- Dependencies: 227
-- Name: access_grant_id_grant_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.access_grant_id_grant_seq', 1, false);


--
-- TOC entry 3431 (class 0 OID 0)
-- Dependencies: 225
-- Name: access_id_access_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.access_id_access_seq', 1, false);


--
-- TOC entry 3432 (class 0 OID 0)
-- Dependencies: 223
-- Name: certificates_id_cert_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.certificates_id_cert_seq', 1, false);


--
-- TOC entry 3433 (class 0 OID 0)
-- Dependencies: 213
-- Name: departments_id_dept_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.departments_id_dept_seq', 10, true);


--
-- TOC entry 3434 (class 0 OID 0)
-- Dependencies: 211
-- Name: employees_id_employee_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.employees_id_employee_seq', 19, true);


--
-- TOC entry 3435 (class 0 OID 0)
-- Dependencies: 229
-- Name: hardware_id_hw_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.hardware_id_hw_seq', 1, false);


--
-- TOC entry 3436 (class 0 OID 0)
-- Dependencies: 231
-- Name: hardware_lease_id_lease_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.hardware_lease_id_lease_seq', 1, false);


--
-- TOC entry 3437 (class 0 OID 0)
-- Dependencies: 219
-- Name: keys_id_key_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.keys_id_key_seq', 1, false);


--
-- TOC entry 3438 (class 0 OID 0)
-- Dependencies: 221
-- Name: keys_lease_id_lease_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.keys_lease_id_lease_seq', 1, false);


--
-- TOC entry 3439 (class 0 OID 0)
-- Dependencies: 215
-- Name: orgs_id_org_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.orgs_id_org_seq', 2, true);


--
-- TOC entry 3440 (class 0 OID 0)
-- Dependencies: 210
-- Name: people_id_people_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.people_id_people_seq', 26, true);


--
-- TOC entry 3441 (class 0 OID 0)
-- Dependencies: 217
-- Name: rooms_id_room_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.rooms_id_room_seq', 13, true);


--
-- TOC entry 3238 (class 2606 OID 16656)
-- Name: access_grant access_grant_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.access_grant
    ADD CONSTRAINT access_grant_pkey PRIMARY KEY (id_grant);


--
-- TOC entry 3236 (class 2606 OID 16650)
-- Name: access access_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.access
    ADD CONSTRAINT access_pkey PRIMARY KEY (id_access);


--
-- TOC entry 3234 (class 2606 OID 16632)
-- Name: certificates certificates_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.certificates
    ADD CONSTRAINT certificates_pkey PRIMARY KEY (id_cert);


--
-- TOC entry 3224 (class 2606 OID 16556)
-- Name: departments departments_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.departments
    ADD CONSTRAINT departments_pkey PRIMARY KEY (id_dept);


--
-- TOC entry 3222 (class 2606 OID 16547)
-- Name: employees employees_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.employees
    ADD CONSTRAINT employees_pkey PRIMARY KEY (id_employee);


--
-- TOC entry 3242 (class 2606 OID 16691)
-- Name: hardware_lease hardware_lease_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hardware_lease
    ADD CONSTRAINT hardware_lease_pkey PRIMARY KEY (id_lease);


--
-- TOC entry 3240 (class 2606 OID 16674)
-- Name: hardware hardware_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hardware
    ADD CONSTRAINT hardware_pkey PRIMARY KEY (id_hw);


--
-- TOC entry 3232 (class 2606 OID 16614)
-- Name: keys_lease keys_lease_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.keys_lease
    ADD CONSTRAINT keys_lease_pkey PRIMARY KEY (id_lease);


--
-- TOC entry 3230 (class 2606 OID 16603)
-- Name: keys keys_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.keys
    ADD CONSTRAINT keys_pkey PRIMARY KEY (id_key);


--
-- TOC entry 3226 (class 2606 OID 16564)
-- Name: orgs orgs_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orgs
    ADD CONSTRAINT orgs_pkey PRIMARY KEY (id_org);


--
-- TOC entry 3220 (class 2606 OID 16537)
-- Name: people people_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.people
    ADD CONSTRAINT people_pkey PRIMARY KEY (id_person);


--
-- TOC entry 3228 (class 2606 OID 16572)
-- Name: rooms rooms_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.rooms
    ADD CONSTRAINT rooms_pkey PRIMARY KEY (id_room);


--
-- TOC entry 3253 (class 2606 OID 16662)
-- Name: access_grant id_access_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.access_grant
    ADD CONSTRAINT id_access_fkey FOREIGN KEY (id_access) REFERENCES public.access(id_access) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3243 (class 2606 OID 16583)
-- Name: employees id_dept_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.employees
    ADD CONSTRAINT id_dept_fkey FOREIGN KEY (id_dept) REFERENCES public.departments(id_dept) ON UPDATE CASCADE ON DELETE SET NULL NOT VALID;


--
-- TOC entry 3256 (class 2606 OID 16692)
-- Name: hardware_lease id_hw_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hardware_lease
    ADD CONSTRAINT id_hw_fkey FOREIGN KEY (id_hw) REFERENCES public.hardware(id_hw) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3249 (class 2606 OID 16615)
-- Name: keys_lease id_key_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.keys_lease
    ADD CONSTRAINT id_key_fkey FOREIGN KEY (id_key) REFERENCES public.keys(id_key) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3247 (class 2606 OID 16573)
-- Name: rooms id_org_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.rooms
    ADD CONSTRAINT id_org_fkey FOREIGN KEY (id_org) REFERENCES public.orgs(id_org) ON UPDATE CASCADE ON DELETE CASCADE NOT VALID;


--
-- TOC entry 3246 (class 2606 OID 16593)
-- Name: departments id_org_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.departments
    ADD CONSTRAINT id_org_fkey FOREIGN KEY (id_org) REFERENCES public.orgs(id_org) ON UPDATE CASCADE ON DELETE CASCADE NOT VALID;


--
-- TOC entry 3254 (class 2606 OID 16675)
-- Name: hardware id_org_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hardware
    ADD CONSTRAINT id_org_fkey FOREIGN KEY (id_org) REFERENCES public.orgs(id_org) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3250 (class 2606 OID 16620)
-- Name: keys_lease id_person_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.keys_lease
    ADD CONSTRAINT id_person_fkey FOREIGN KEY (id_person) REFERENCES public.people(id_person) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3251 (class 2606 OID 16633)
-- Name: certificates id_person_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.certificates
    ADD CONSTRAINT id_person_fkey FOREIGN KEY (id_person) REFERENCES public.people(id_person) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3252 (class 2606 OID 16657)
-- Name: access_grant id_person_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.access_grant
    ADD CONSTRAINT id_person_fkey FOREIGN KEY (id_person) REFERENCES public.people(id_person) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3257 (class 2606 OID 16697)
-- Name: hardware_lease id_person_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hardware_lease
    ADD CONSTRAINT id_person_fkey FOREIGN KEY (id_person) REFERENCES public.people(id_person) ON UPDATE CASCADE ON DELETE SET NULL;


--
-- TOC entry 3245 (class 2606 OID 16702)
-- Name: employees id_person_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.employees
    ADD CONSTRAINT id_person_fkey FOREIGN KEY (id_person) REFERENCES public.people(id_person) ON UPDATE CASCADE ON DELETE CASCADE NOT VALID;


--
-- TOC entry 3244 (class 2606 OID 16588)
-- Name: employees id_room_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.employees
    ADD CONSTRAINT id_room_fkey FOREIGN KEY (id_room) REFERENCES public.rooms(id_room) ON UPDATE CASCADE ON DELETE SET NULL NOT VALID;


--
-- TOC entry 3248 (class 2606 OID 16604)
-- Name: keys id_room_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.keys
    ADD CONSTRAINT id_room_fkey FOREIGN KEY (id_room) REFERENCES public.rooms(id_room) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 3255 (class 2606 OID 16681)
-- Name: hardware id_room_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.hardware
    ADD CONSTRAINT id_room_fkey FOREIGN KEY (id_room) REFERENCES public.rooms(id_room) ON UPDATE CASCADE ON DELETE SET NULL NOT VALID;


--
-- TOC entry 3428 (class 0 OID 0)
-- Dependencies: 3426
-- Name: DATABASE personnel_mgt; Type: ACL; Schema: -; Owner: postgres
--

REVOKE CONNECT,TEMPORARY ON DATABASE personnel_mgt FROM PUBLIC;
GRANT TEMPORARY ON DATABASE personnel_mgt TO PUBLIC;
GRANT ALL ON DATABASE personnel_mgt TO user1;


--
-- TOC entry 3429 (class 0 OID 0)
-- Dependencies: 3
-- Name: SCHEMA public; Type: ACL; Schema: -; Owner: postgres
--

GRANT USAGE ON SCHEMA public TO user1;


-- Completed on 2022-06-05 14:29:04

--
-- PostgreSQL database dump complete
--

