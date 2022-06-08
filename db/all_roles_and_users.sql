--
-- PostgreSQL database cluster dump
--

SET default_transaction_read_only = off;

SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;

--
-- Roles
--

CREATE ROLE postgres;
ALTER ROLE postgres WITH SUPERUSER INHERIT CREATEROLE CREATEDB LOGIN REPLICATION BYPASSRLS PASSWORD 'SCRAM-SHA-256$4096:k9a5Adwdqr9tKgFicnm6IQ==$IN/vjK6XZy5NllMJeOsK75z4g/vVBq9ly0L8li7Nalo=:mrdwvZhRyxGodhhoHpDKJp7HFtKczGGs17OqMiBXvKk=';
CREATE ROLE role_generic_billing;
ALTER ROLE role_generic_billing WITH NOSUPERUSER INHERIT NOCREATEROLE NOCREATEDB NOLOGIN NOREPLICATION NOBYPASSRLS;
CREATE ROLE test_generic_user;
ALTER ROLE test_generic_user WITH NOSUPERUSER INHERIT NOCREATEROLE NOCREATEDB LOGIN NOREPLICATION NOBYPASSRLS;
CREATE ROLE user1;
ALTER ROLE user1 WITH NOSUPERUSER INHERIT NOCREATEROLE NOCREATEDB LOGIN NOREPLICATION NOBYPASSRLS PASSWORD 'SCRAM-SHA-256$4096:kWaTpnLPY/G9XhUZpLSszQ==$isNAGZYKbKwxhFXm866pBcir5xQy/69S1dSRJuO8Xt0=:JTzguJ1PkkX9MF11rBK19uBCOSApL5KN12njwK4tOcs=';
COMMENT ON ROLE user1 IS 'Для ИС "Сотрудники компании", имеет полный доступ только к PersonnelMgtDB';


--
-- Role memberships
--

GRANT pg_read_all_data TO user1 GRANTED BY postgres;
GRANT pg_write_all_data TO user1 GRANTED BY postgres;




--
-- Databases
--

--
-- Database "template1" dump
--

\connect template1

--
-- PostgreSQL database dump
--

-- Dumped from database version 14.3
-- Dumped by pg_dump version 14.3

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
-- PostgreSQL database dump complete
--

--
-- Database "billing" dump
--

--
-- PostgreSQL database dump
--

-- Dumped from database version 14.3
-- Dumped by pg_dump version 14.3

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
-- Name: billing; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE billing WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';


ALTER DATABASE billing OWNER TO postgres;

\connect billing

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
-- Name: pgcrypto; Type: EXTENSION; Schema: -; Owner: -
--

CREATE EXTENSION IF NOT EXISTS pgcrypto WITH SCHEMA public;


--
-- Name: EXTENSION pgcrypto; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION pgcrypto IS 'cryptographic functions';


SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: billing; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.billing (
    id_billing integer NOT NULL,
    id_phone integer,
    date_since date,
    date_till date,
    sum_nds numeric
);


ALTER TABLE public.billing OWNER TO postgres;

--
-- Name: billing_id_billing_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.billing_id_billing_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.billing_id_billing_seq OWNER TO postgres;

--
-- Name: billing_id_billing_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.billing_id_billing_seq OWNED BY public.billing.id_billing;


--
-- Name: departments; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.departments (
    id_dept integer NOT NULL,
    name text NOT NULL,
    id_org integer
);


ALTER TABLE public.departments OWNER TO postgres;

--
-- Name: TABLE departments; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.departments IS 'Подразделения';


--
-- Name: departments_id_dept_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.departments_id_dept_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.departments_id_dept_seq OWNER TO postgres;

--
-- Name: departments_id_dept_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.departments_id_dept_seq OWNED BY public.departments.id_dept;


--
-- Name: orgs; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.orgs (
    id_org integer NOT NULL,
    name text NOT NULL,
    details text
);


ALTER TABLE public.orgs OWNER TO postgres;

--
-- Name: orgs_id_org_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.orgs_id_org_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.orgs_id_org_seq OWNER TO postgres;

--
-- Name: orgs_id_org_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.orgs_id_org_seq OWNED BY public.orgs.id_org;


--
-- Name: personnel; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.personnel (
    id_person integer NOT NULL,
    name_full text,
    id_dept integer,
    "position" text
);


ALTER TABLE public.personnel OWNER TO postgres;

--
-- Name: TABLE personnel; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON TABLE public.personnel IS 'Сотрудники';


--
-- Name: personnel_id_person_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.personnel_id_person_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.personnel_id_person_seq OWNER TO postgres;

--
-- Name: personnel_id_person_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.personnel_id_person_seq OWNED BY public.personnel.id_person;


--
-- Name: phones; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.phones (
    id_phone integer NOT NULL,
    id_person integer,
    number text,
    operator text,
    id_org integer,
    is_active boolean
);


ALTER TABLE public.phones OWNER TO postgres;

--
-- Name: phones_id_phone_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.phones_id_phone_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.phones_id_phone_seq OWNER TO postgres;

--
-- Name: phones_id_phone_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.phones_id_phone_seq OWNED BY public.phones.id_phone;


--
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    id integer NOT NULL,
    login text NOT NULL,
    pass text,
    salt text,
    role text
);


ALTER TABLE public.users OWNER TO postgres;

--
-- Name: users_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.users_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.users_id_seq OWNER TO postgres;

--
-- Name: users_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.users_id_seq OWNED BY public.users.id;


--
-- Name: billing id_billing; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.billing ALTER COLUMN id_billing SET DEFAULT nextval('public.billing_id_billing_seq'::regclass);


--
-- Name: departments id_dept; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.departments ALTER COLUMN id_dept SET DEFAULT nextval('public.departments_id_dept_seq'::regclass);


--
-- Name: orgs id_org; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orgs ALTER COLUMN id_org SET DEFAULT nextval('public.orgs_id_org_seq'::regclass);


--
-- Name: personnel id_person; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.personnel ALTER COLUMN id_person SET DEFAULT nextval('public.personnel_id_person_seq'::regclass);


--
-- Name: phones id_phone; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.phones ALTER COLUMN id_phone SET DEFAULT nextval('public.phones_id_phone_seq'::regclass);


--
-- Name: users id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users ALTER COLUMN id SET DEFAULT nextval('public.users_id_seq'::regclass);


--
-- Data for Name: billing; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.billing (id_billing, id_phone, date_since, date_till, sum_nds) FROM stdin;
40	1	2015-07-01	2015-07-01	226.60
41	2	2015-07-01	2015-07-01	246.50
42	3	2015-07-01	2015-07-01	327.10
43	4	2015-07-01	2015-07-01	88.70
44	5	2015-07-01	2015-07-01	344.25
45	1	2015-07-01	2015-07-01	226.60
46	2	2015-07-01	2015-07-01	246.50
47	3	2015-07-01	2015-07-01	327.10
48	4	2015-07-01	2015-07-01	88.70
49	5	2015-07-01	2015-07-01	344.25
\.


--
-- Data for Name: departments; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.departments (id_dept, name, id_org) FROM stdin;
2	Бухгалтерия	1
3	Отдел продаж	1
1	Управление	1
4	Отдел поставок	2
\.


--
-- Data for Name: orgs; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.orgs (id_org, name, details) FROM stdin;
1	"Наименование" ООО	610000, г. Киров, Октябрьский пр-т, д. 10, этаж 2
2	"Другая организация" ООО	<данные отсутствуют>
\.


--
-- Data for Name: personnel; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.personnel (id_person, name_full, id_dept, "position") FROM stdin;
1	Сырцев Сергей Александрович	1	Программист
2	Петрова Анна Леонидовна	2	Бухгалтер
3	Григорьев Яровслав Борисович	3	Менеджер по продажам
4	Гребнев Михаил Сергеевич	3	Менеджер по продажам
5	Горьких Василий Игоревич	1	Заместитель директора
6	Бакулева Татьяна Александровна	4	Менеджер по поставкам
\.


--
-- Data for Name: phones; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.phones (id_phone, id_person, number, operator, id_org, is_active) FROM stdin;
1	1	89226610119	Мегафон	1	t
2	2	89226612144	Мегафон	1	t
3	3	89226612627	Мегафон	1	t
4	4	89226624144	Мегафон	1	t
5	5	89226625662	Мегафон	1	t
7	6	89226628780	Мегафон	2	t
\.


--
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.users (id, login, pass, salt, role) FROM stdin;
2	admin	xlGyAqeRSeVD1IAp0CV1BRRkTGF2fDAL	NX0L217Z7bCcqweN86e9MS4wI4MZrvWD	ROLE_ADMIN
3	user1	5pX2w01DbbauuRcS0EnWaUQLHW+O98NX	PbqLLJYtJ6fPgaRwPj7B4QKsEZpThR4X	ROLE_GENERIC_BILLING
4	student	dDm0R585HvoyCUNReICVj3szonz5hdCn	idF11G9UoqROT+fCuA3S/AN+Rwxw7M8F	ROLE_GENERIC_BILLING
7	user2	K6GABiKhsu9noMo++KMvrQC/v1mWIqnF	8Abm8YiqDF8ysq8aTHfKtfG+eNaTde6y	ROLE_GENERIC_BILLING
\.


--
-- Name: billing_id_billing_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.billing_id_billing_seq', 49, true);


--
-- Name: departments_id_dept_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.departments_id_dept_seq', 4, true);


--
-- Name: orgs_id_org_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.orgs_id_org_seq', 2, true);


--
-- Name: personnel_id_person_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.personnel_id_person_seq', 6, true);


--
-- Name: phones_id_phone_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.phones_id_phone_seq', 7, true);


--
-- Name: users_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.users_id_seq', 7, true);


--
-- Name: departments ID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.departments
    ADD CONSTRAINT "ID" PRIMARY KEY (id_dept);


--
-- Name: billing billing_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.billing
    ADD CONSTRAINT billing_pkey PRIMARY KEY (id_billing);


--
-- Name: orgs orgs_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orgs
    ADD CONSTRAINT orgs_pkey PRIMARY KEY (id_org);


--
-- Name: personnel personnel_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.personnel
    ADD CONSTRAINT personnel_pkey PRIMARY KEY (id_person);


--
-- Name: phones phones_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.phones
    ADD CONSTRAINT phones_pkey PRIMARY KEY (id_phone);


--
-- Name: users users_login_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_login_key UNIQUE (login);


--
-- Name: users users_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);


--
-- Name: personnel id_dept; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.personnel
    ADD CONSTRAINT id_dept FOREIGN KEY (id_dept) REFERENCES public.departments(id_dept) ON UPDATE CASCADE ON DELETE SET NULL NOT VALID;


--
-- Name: departments id_org; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.departments
    ADD CONSTRAINT id_org FOREIGN KEY (id_org) REFERENCES public.orgs(id_org) ON UPDATE CASCADE ON DELETE SET NULL NOT VALID;


--
-- Name: phones id_org; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.phones
    ADD CONSTRAINT id_org FOREIGN KEY (id_org) REFERENCES public.orgs(id_org) ON UPDATE CASCADE ON DELETE SET NULL NOT VALID;


--
-- Name: phones id_person; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.phones
    ADD CONSTRAINT id_person FOREIGN KEY (id_person) REFERENCES public.personnel(id_person) ON UPDATE CASCADE ON DELETE SET NULL;


--
-- Name: billing id_phone; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.billing
    ADD CONSTRAINT id_phone FOREIGN KEY (id_phone) REFERENCES public.phones(id_phone) ON UPDATE CASCADE ON DELETE SET NULL;


--
-- PostgreSQL database dump complete
--

--
-- Database "personnel_mgt" dump
--

