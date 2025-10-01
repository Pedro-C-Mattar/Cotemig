
select 
	Name,
    Code,
    continent,
    region,
    population
from
	country
where
	 LifeExpectancy < 70 and GovernmentForm = 'Republic';
    
select 
	name,
    district,
    population
from
	city
where
	Name like 'K%' and district like 'N_t%' and population > 10000;
    
select 
	continent,
    sum(population) as Populacao_por_Continente
from
	country
group by
	continent;
    
select 
	count(code) as Quantidade_Paises,
    sum(population) as Populacao_Total,
    max(population) as Maior_Populacao,
    min(population) as Menor_Populacao,
    avg(population) as Media_Populacao
from
	country;
    
select 
	*
from
	countryLanguage
where
	percentage between 20 and 50 and IsOfficial = 'T';